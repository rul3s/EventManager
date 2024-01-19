using EmBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmBackend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Event> Events { get; set; }
    }
}
