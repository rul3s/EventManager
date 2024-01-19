using EmBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmBackend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
