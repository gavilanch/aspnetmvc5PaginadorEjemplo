namespace PaginadorMVC5.Migrations
{
    using PaginadorMVC5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PaginadorMVC5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PaginadorMVC5.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Personas.AddOrUpdate(
              p => p.Nombre,
              new Persona { Nombre = "Andrew Peters", Edad = 45 },
              new Persona { Nombre = "Brice Lambson", Edad = 17 },
              new Persona { Nombre = "Rowan Miller", Edad = 19 },
              new Persona { Nombre = "Rowan Miller1", Edad = 19 },
              new Persona { Nombre = "Rowan Miller2", Edad = 19 },
              new Persona { Nombre = "Rowan Miller3", Edad = 19 },
              new Persona { Nombre = "Rowan Miller4", Edad = 19 },
              new Persona { Nombre = "Rowan Miller5", Edad = 19 },
              new Persona { Nombre = "Rowan Miller6", Edad = 19 },
              new Persona { Nombre = "Rowan Miller7", Edad = 19 },
              new Persona { Nombre = "Rowan Miller9", Edad = 19 },
              new Persona { Nombre = "Rowan Miller8", Edad = 19 }
            );

        }
    }
}
