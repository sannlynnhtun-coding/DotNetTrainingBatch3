using DotNetTrainingBatch3.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogApiController : ControllerBase
    {
        private readonly AppDbContext _db;

        public BlogApiController()
        {
            _db = new AppDbContext();
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            List<BlogModel> lst = _db.Blogs.OrderByDescending(x => x.BlogId).ToList();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            BlogModel? item = _db.Blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
                return NotFound("No data found.");
            }

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateBlog(BlogModel blog)
        {
            _db.Blogs.Add(blog);
            int result = _db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            return Ok(message);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, BlogModel blog)
        {
            BlogModel? item = _db.Blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
                return NotFound("No data found.");
            }

            item.BlogTitle = blog.BlogTitle;
            item.BlogAuthor = blog.BlogAuthor;
            item.BlogContent = blog.BlogContent;
            int result = _db.SaveChanges();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            BlogModel? item = _db.Blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
                return NotFound("No data found.");
            }

            _db.Blogs.Remove(item);
            int result = _db.SaveChanges();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            return Ok(message);
        }
    }
}
