using System.Data.Entity;
using PC.Model;

namespace PC.DAL
{
    public class PersonalComputerContextDbContext: DbContext
    {
        public PersonalComputerContextDbContext()
            : base("PCStore")
        { }

        public DbSet<Laptop> Laptops { get; set; }
    }
}

