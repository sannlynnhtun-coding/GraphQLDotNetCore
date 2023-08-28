using Microsoft.EntityFrameworkCore;

namespace GraphQLDotNetCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
