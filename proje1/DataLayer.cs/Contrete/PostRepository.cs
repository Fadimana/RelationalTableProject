using DataLayer.cs.Context;
using DataLayer.cs.Entity;
using DataLayer.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.cs.Contrete
{
    public class PostRepository : IPostRepository
    {
        private readonly DBContext _context;

        public PostRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<Post> CreatePost(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<Post> DeletePost(int id)
        {
            Post post=await _context.Posts.FindAsync(id);
             _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<List<Post>> GetAllPost()
        {
            return await _context.Posts.Include(p => p.Blog).ToListAsync();
            
        }

        public async Task<Post> UpdatePost(Post post)
        {
            _context.Posts.Update(post);    
            await _context.SaveChangesAsync();
            return post;
        }
    }
}
