using efloading.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efloading.EF
{
    internal class Appdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ARMAN\SQLEXPRESS;Database=EFloading;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<course> courses { get; set; }
    }
}
