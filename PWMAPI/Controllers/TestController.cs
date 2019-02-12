using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PWMAPI.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : Controller
    {
        public string Index()
        {
            return "It's working correctly";
        }
    }
}