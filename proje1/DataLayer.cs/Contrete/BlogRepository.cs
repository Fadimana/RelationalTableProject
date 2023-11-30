using DataLayer.cs.Context;
using DataLayer.cs.Entity;
using DataLayer.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.cs.Contrete
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DBContext _context;

        public BlogRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<Blog> CreateBlog(Blog blog)
        {
            await _context.AddAsync(blog);
            await _context.SaveChangesAsync();
            return blog;

        }
        public async Task<List<Blog>> GetBlogAll()
        {
            var result =await _context.Blogs.Include(p=>p.Posts).ToListAsync(); 
            return result;
        }

        public async Task<Blog> UpdateBlog(Blog blog)
        {
            _context.UpdateRange(blog);
            await _context.SaveChangesAsync();
            return blog;
        }

        //İd si girilen bloğun ve ona bağlı olan postların silinmesi.
        public async Task<Blog> DeleteBlog(int BlogId)
        {
            Blog blog= await _context.Blogs.Include(x => x.Posts).FirstOrDefaultAsync(x => x.id == BlogId);
            Post post=blog.Posts.FirstOrDefault(x=>x.BlogId == BlogId);
            _context.RemoveRange(blog,post);
            await _context.SaveChangesAsync();
            return blog;
        }

    }
}
