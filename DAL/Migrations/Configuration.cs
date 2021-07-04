using System.Collections.Generic;
using PC.Model;

namespace PC.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PC.DAL.PersonalComputerContextDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PersonalComputerContextDbContext context)
        {

            for (int i = 0; i < 100; i++)
            {
                context.Laptops
                   .AddOrUpdate(x=> x.Id,
                       new Laptop()
                       {
                           Id = i,
                           Name = $"Laptop-{i}",
                           Description = $"Description-{i}",
                           Price = i,
                           HashCode = $"1-{i}-9"
                       });
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
