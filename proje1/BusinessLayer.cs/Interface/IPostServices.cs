using DataLayer.cs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.cs.Interface
{
    public interface IPostServices
    {
        Task<List<Post>> GetAllPost();
        Task<Post> CreatePost(Post post);

        Task<Post> UpdatePost(Post post);

        Task <Post> DeletePost(int id);
    }
}
