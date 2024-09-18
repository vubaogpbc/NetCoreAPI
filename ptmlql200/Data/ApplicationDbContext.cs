using Microsoft.EntityFrameworkCore;
using ptpmql200.Models;

namespace ptpmql200.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Persons { get; set; }
    }
}
