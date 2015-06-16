using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Approach___Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext())
            {
                var newBlog = new Blog { BloggerName = "Prasad", Name = "Technical Blog" };
                context.Blogs.Add(newBlog); //db gets created here...
                context.SaveChanges();

                Console.WriteLine("Database created successfully");
                Console.ReadLine();
            }
        }
    }

    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string BloggerName { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}
