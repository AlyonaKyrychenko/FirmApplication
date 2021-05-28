using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firm.Data.Repositories;

namespace Firm.Data
{
    public class FirmContext : DbContext
    {
        public FirmContext() : base("Default") { }

        public FirmContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Foreman> Foremen { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasKey(x => x.Id);
        }
    }
}
