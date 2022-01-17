using IDCodingExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace IDCodingExercise.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Region> Region { get; set; }
        public DbSet<ABSPopulationValues> ABSPopulationValues { get; set; }

    }
}
