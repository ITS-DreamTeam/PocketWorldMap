using Microsoft.EntityFrameworkCore;
using PWMAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWMAPI.Contexts
{
    public class PWMContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Marker> Markers { get; set; }
        public DbSet<PublicMap> PublicMaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=den1.mssql7.gear.host;User ID=pwmapi;Password=Sw8ZMQ56!~Z9;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
