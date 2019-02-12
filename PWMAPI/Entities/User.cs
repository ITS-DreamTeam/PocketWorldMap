using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWMAPI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }  

        public PublicMap Map { get; set; }
        public ICollection<Marker> Markers { get; set; }
    }
}
