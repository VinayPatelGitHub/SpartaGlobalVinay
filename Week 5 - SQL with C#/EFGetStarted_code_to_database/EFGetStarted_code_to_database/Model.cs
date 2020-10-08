using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Website> Websites { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Blogging;");
    }

   

    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string CreationDate { get; set; }
        public string Content { get; set; }        

        public Blog Blog { get; set; }
        public User User { get; set; }
        public List<Website> Websites { get; } = new List<Website>();
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }

        public List<Post> Posts { get; } = new List<Post>();        
    }

    public class Website
    {
        public int WebsiteId { get; set; }
        public int PostId { get; set; }
        public string WebsiteAddress { get; set; }

        public Post Post { get; set; }

    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }

        public List<Post> Posts { get; } = new List<Post>();

    }
}