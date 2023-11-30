using BusinessLayer.cs.Interface;
using DataLayer.cs.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace proje1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBlogServices _blogServices;
        private readonly IPostServices _postServices;


        public ValuesController(IBlogServices blogServices, IPostServices postServices)
        {
            _blogServices = blogServices;
            _postServices = postServices;
        }

        [HttpPost("Blog")]
        public async Task<IActionResult> CreateBlog(Blog blog )
        {
            if(ModelState.IsValid)
            {
                var result =await _blogServices.CreateBlog(blog);
                
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() { 
            var result= await _blogServices.GetBlogAll();
            return Ok(result);  
        
        }
        [HttpDelete("Blog")]
        public async Task<IActionResult> DeleteBlog(int BlokId)
        {
            if(ModelState.IsValid)
            {
                var result = await _blogServices.DeleteBlog(BlokId);
                return Ok(result);
            }
            return BadRequest();
           
        }

        [HttpPut("Blog")]
        public async Task<IActionResult> UpdateBlog(Blog blog) {

            if (ModelState.IsValid)
            {
                var result = await _blogServices.UpdateBlog(blog);
                return Ok(result);
            }
            return BadRequest();
           
        
        }
        [HttpPost("Post")]
        public async Task<IActionResult> CreatePost(Post post)
        {
            if (ModelState.IsValid)
            {
                var result = await _postServices.CreatePost(post);

                return Ok();
            }
            return BadRequest();
        }
        [HttpGet("Post")]
        public async Task<IActionResult> GetAllPost()
        {
            var result = await _postServices.GetAllPost();
            return Ok(result);

        }
        [HttpDelete("Post")]
        public async Task<IActionResult> DeletePost(int postıd)
        {
            if (ModelState.IsValid)
            {
                var result = await _postServices.DeletePost(postıd);
                return Ok(result);
            }
            return BadRequest();
           
        }

        [HttpPut("Post")]
        public async Task<IActionResult> UpdatePost(Post post)
        {
            if (ModelState.IsValid)
            {
                var result = await _postServices.UpdatePost(post);
                return Ok(result);
            }
            return BadRequest();
            
            

        }
    }
}
