
using Microsoft.EntityFrameworkCore;
using Group_Assignment_4.Models;

namespace Group_Assignment_4.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Parks> Parks { get; set; }
        public DbSet<Park> Park { get; set; }
        public DbSet<Tours> Tours { get; set; }
        public DbSet<Tour> Tour { get; set; }

    }
}
