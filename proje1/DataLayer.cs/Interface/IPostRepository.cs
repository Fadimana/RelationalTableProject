using DataLayer.cs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.cs.Interface
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllPost();
        Task<Post> CreatePost(Post post);

        Task<Post> UpdatePost(Post post);

        Task <Post>DeletePost(int id);


    }
}
