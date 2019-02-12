using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWMAPI.Contexts;
using PWMAPI.Entities;

namespace PWMAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MarkersController : ControllerBase
    {
        private readonly PWMContext _context;
        private int _userId;

        public MarkersController(PWMContext context)
        {
            _context = context;
        }

        // GET: api/Markers
        [HttpGet]
        public IEnumerable<Marker> GetMarkers()
        {
            GetUserId();
            return _context.Markers.Where(x => x.UserId == _userId);
        }

        // PUT: api/Markers/5
        [HttpPut]
        public async Task<IActionResult> PutMarker([FromBody] Marker marker)
        {
            GetUserId();
            marker.UserId = _userId;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(marker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Markers
        [HttpPost]
        public async Task<IActionResult> PostMarker([FromBody] Marker marker)
        {
            GetUserId();
            marker.MarkerId = 0;
            marker.UserId = _userId;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(_context.Markers.Where(x => x.UserId == _userId).Any(x => x.Latitude == marker.Latitude && x.Longitude == marker.Longitude))
            {
                return BadRequest(new { message = "You have saved place with this geocordinates" });
            }
            _context.Markers.Add(marker);
            await _context.SaveChangesAsync();

            return Ok(marker);
        }

        // DELETE: api/Markers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarker([FromRoute] int id)
        {
            GetUserId();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var marker = await _context.Markers.FindAsync(id);
            if (marker == null || marker.UserId != _userId)
            {
                return NotFound();
            }

            _context.Markers.Remove(marker);
            await _context.SaveChangesAsync();

            return Ok(marker);
        }

        private bool MarkerExists(int id)
        {
            return _context.Markers.Any(e => e.MarkerId == id);
        }

        private void GetUserId()
        {
            _userId = Int32.Parse(User.Identity.Name);
        }
    }
}