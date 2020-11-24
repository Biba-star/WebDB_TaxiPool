using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Data
{
    public class WebDB_TaxiPoolContext : DbContext
    {
        public WebDB_TaxiPoolContext (DbContextOptions<WebDB_TaxiPoolContext> options)
            : base(options)
        {
        }

        public DbSet<WebDB_TaxiPool.Models.Auto> Auto { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Brand> Brand { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Call> Call { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Position> Position { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Rate> Rate { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Service> Service { get; set; }

        public DbSet<WebDB_TaxiPool.Models.Staff> Staff { get; set; }
    }
}
