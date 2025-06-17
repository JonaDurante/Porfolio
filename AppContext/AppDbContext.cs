using Microsoft.EntityFrameworkCore;
using Models;

namespace AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TechnologyExperience> TechnologyExperiences { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
