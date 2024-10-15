using System;
using System.Collection.Generic;
using System.Ling;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ptpmql200.Models;

namespace ptpmql200.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
             : base(options)
    {
    }
        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
