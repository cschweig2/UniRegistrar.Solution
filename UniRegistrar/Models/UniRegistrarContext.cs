using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UniRegistrar.Models
{
    public class UniRegistrarContext : IdentityDbContext<ApplicationUser>
    {
        // public virtual DbSet<Category> Categories { get; set; }
        // public DbSet<Item> Items { get; set; }
        // public DbSet<CategoryItem> CategoryItem { get; set; }

        public UniRegistrarContext(DbContextOptions options) : base(options) { }
    }
}