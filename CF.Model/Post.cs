using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Runtime.Remoting.Contexts;

namespace CF.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogContext>());
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Mapping : EntityMappingConfiguration<Blog>
    {
        
    }

    public class Test
    {
        private void dfsgdsg()
        {
            var context = new BlogContext();
            context.Database.sq
        }
    }
}