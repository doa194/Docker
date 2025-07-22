using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Item> Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}