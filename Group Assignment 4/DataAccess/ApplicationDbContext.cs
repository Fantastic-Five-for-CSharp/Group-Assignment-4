
using Microsoft.EntityFrameworkCore;
using Group_Assignment_4.Models;

namespace Group_Assignment_4.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Parks> Park { get; set; }
        public DbSet<Tours> Tour { get; set; }
    }
}
