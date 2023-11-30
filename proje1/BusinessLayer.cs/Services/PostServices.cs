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
    public class PostServices : IPostServices
    {
        private readonly IPostRepository _postRepository;

        public PostServices(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> CreatePost(Post post)
        {
            if (post.title == null) throw new ArgumentNullException();
            else
            {
                return await _postRepository.CreatePost(post);  
            }
        }
        
        public  async Task<Post> DeletePost(int id)
        {
            if(id < 0) throw new ArgumentOutOfRangeException();
            else
                return  await _postRepository.DeletePost(id); 
        }

        public async Task<List<Post>> GetAllPost()
        {
           return await _postRepository.GetAllPost();
        }

        public Task<Post> UpdatePost(Post post)
        {
            return _postRepository.UpdatePost(post);    
        }
    }
}
