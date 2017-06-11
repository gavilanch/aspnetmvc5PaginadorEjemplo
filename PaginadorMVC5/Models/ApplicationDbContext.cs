using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PaginadorMVC5.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Persona>().ToTable("Personas");

            base.OnModelCreating(modelBuilder);
        }
    }
}