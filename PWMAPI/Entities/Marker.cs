using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PWMAPI.Entities
{
    public class Marker
    {
        [Key]
        public int MarkerId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsPublic { get; set; }
        [StringLength(256)]
        public string Title { get; set; }
        [StringLength(50000)]
        public string Description { get; set; }
        [Column(TypeName ="DATE")]
        public DateTime Date { get; set; }
        [StringLength(50000)]
        public string ImageUrl { get; set; }
        [StringLength(50000)]
        public string IconUrl { get; set; }

        public int UserId { get; set; }
    }
}
