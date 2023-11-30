using DataLayer.cs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.cs.Interface
{
    public interface IBlogServices
    {
        Task<Blog> CreateBlog(Blog blog);
        Task<Blog> UpdateBlog(Blog blog);

        Task <Blog>DeleteBlog(int BlogId);

        Task<List<Blog>> GetBlogAll();
    }
}
