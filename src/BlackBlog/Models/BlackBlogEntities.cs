using System.Data.Entity;

namespace BlackBlog.Models
{
    public class BlackBlogEntities : DbContext
    {
        public DbSet<Post> Posts { get; set; }

    }
}