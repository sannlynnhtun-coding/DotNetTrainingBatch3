using DotNetTrainingBatch3.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    // https://localhost:7021/Blog/Index
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController()
        {
            _context = new AppDbContext();
        }

        // https://localhost:7021/Blog/Index
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            List<BlogModel> lst = _context.Blogs.ToList();
            return View("BlogIndex", lst);
        }
    }
}
