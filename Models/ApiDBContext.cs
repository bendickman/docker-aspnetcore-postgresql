using dockerapi.Maps;
using Microsoft.EntityFrameworkCore;

namespace dockerapi.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
       : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BlogMap(modelBuilder.Entity<Blog>());
        }
    }
}