using GraphQLDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDotNetCore
{
    public class BlogQuery
    {
        public async Task<List<BlogModel>> GetBlogsAsync([Service] AppDbContext db, int pageNo, int pageSize)
        {
            return await db.Blogs.Skip((pageNo - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<BlogModel> CreateBlog([Service] AppDbContext db, BlogModel blog)
        {
            await db.Blogs.AddAsync(blog);
            await db.SaveChangesAsync();
            return blog;
        }
    }
}
