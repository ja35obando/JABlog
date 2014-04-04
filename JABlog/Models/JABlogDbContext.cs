using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace JABlog.Models
{
    public class JABlogDbContext : DbContext
    {
        public JABlogDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Blogger> Blogers { get; set; }
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}