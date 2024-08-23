using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Context
{
    public class SpotDBContext : DbContext
    {
        public DbSet<Spot> Spot { get; set; } //database table match
        public DbSet<Flow> Flow { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-R6HQSGCC;Database=SpotDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;", null);
        }
    }
}
