using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PWMAPI.Entities
{
    public class PublicMap
    {
        public int PublicMapId { get; set; }
        
        [StringLength(1024)]
        public string Description { get; set; }
        [StringLength(512)]
        public string Url { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
