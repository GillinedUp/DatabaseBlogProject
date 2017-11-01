using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBlogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                var blogForm = new DatabaseBlogProjectForm();
                blogForm.ShowDialog();
            }
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public int UserId { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual User User { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }

public class BlogContext : DbContext
{
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Description)
                .HasColumnName("DetailedDescription");
            modelBuilder.Entity<User>()
                .HasKey(t => t.UserId);
            modelBuilder.Entity<Blog>()
                .HasKey(t => t.BlogId);
            modelBuilder.Entity<Post>()
                .HasKey(t => t.PostId);
            modelBuilder.Entity<Blog>()
                .HasMany(t => t.Posts);
            modelBuilder.Entity<User>()
                .HasMany(t => t.Blogs);
        }
    }

    
}
