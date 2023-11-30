using DataLayer.cs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.cs.Interface
{
    public interface IBlogRepository
    {
        Task<Blog> CreateBlog(Blog blog);
        Task<Blog> UpdateBlog(Blog blog);

        Task<Blog> DeleteBlog(int BlogId);

        Task<List<Blog>> GetBlogAll();
    }
}
