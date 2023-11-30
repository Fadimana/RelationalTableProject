using BusinessLayer.cs.Interface;
using DataLayer.cs.Entity;
using DataLayer.cs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.cs.Services
{
    public class BlogServices : IBlogServices
    {
        private readonly IBlogRepository _blogRepository;

        public BlogServices(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public Task<Blog> CreateBlog(Blog blog)
        {
            if (blog == null) throw new ArgumentNullException();
            else
            return _blogRepository.CreateBlog(blog);
        }

        public async Task<Blog> DeleteBlog(int BlogId)
        {
            if(BlogId < 0)  throw new ArgumentOutOfRangeException();
            else
            return await _blogRepository.DeleteBlog(BlogId);

        }

        public Task<List<Blog>> GetBlogAll()
        {
            return _blogRepository.GetBlogAll();
        }

        public Task<Blog> UpdateBlog(Blog blog)
        {
            if (blog == null) { throw new ArgumentNullException(); }
            else
            return _blogRepository.UpdateBlog(blog);
        }
    }

    }

