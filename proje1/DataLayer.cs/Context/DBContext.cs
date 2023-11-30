using DataLayer.cs.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace DataLayer.cs.Context
{
    public class DBContext :DbContext
    {
        public DbSet<Blog>Blogs { get; set; }   
        public DbSet<Post> Posts { get; set; }

        public DBContext(DbContextOptions<DBContext> options): base(options)
        {
            
        }
    }
}