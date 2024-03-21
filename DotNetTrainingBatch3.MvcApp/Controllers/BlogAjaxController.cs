using DotNetTrainingBatch3.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    // https://localhost:7021/Blog/Index
    public class BlogAjaxController : Controller
    {
        private readonly AppDbContext _context;

        public BlogAjaxController(AppDbContext context)
        {
            _context = context;
        }


        // https://localhost:7021/Blog/Index
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            List<BlogModel> lst = _context.Blogs.ToList();
            return View("BlogIndex", lst);
        }

        // https://localhost:7021/Blog/Edit/1
        // https://localhost:7021/Blog/Edit?id=1
        [ActionName("Edit")]
        public IActionResult BlogEdit(int id)
        {
            var item = _context.Blogs.FirstOrDefault(x => x.BlogId == id);
            if (item is null)
            {
                return Redirect("/Blog");
            }

            return View("BlogEdit", item);
        }

        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        [HttpPost]
        [ActionName("Save")]
        public IActionResult BlogSave(BlogModel blog)
        {
            _context.Blogs.Add(blog);
            int result = _context.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            BlogMessageResponseModel model = new BlogMessageResponseModel()
            {
                IsSuccess = result > 0,
                Message = message
            };
            return Json(model);
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult BlogUpdate(int id, BlogModel blog)
        {
            BlogMessageResponseModel model = new BlogMessageResponseModel();
            var item = _context.Blogs.FirstOrDefault(x => x.BlogId == id);
            if (item is null)
            {
                //model.IsSuccess = false;
                //model.Message = "No data found.";
                model = new BlogMessageResponseModel()
                {
                    IsSuccess = false,
                    Message = "No data found."
                };
                return Json(model);
            }

            item.BlogTitle = blog.BlogTitle;
            item.BlogAuthor = blog.BlogAuthor;
            item.BlogContent = blog.BlogContent;

            int result = _context.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            model = new BlogMessageResponseModel()
            {
                IsSuccess = result > 0,
                Message = message
            };
            return Json(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult BlogDelete(BlogModel blog)
        {
            BlogMessageResponseModel model = new BlogMessageResponseModel();
            var item = _context.Blogs.FirstOrDefault(x => x.BlogId == blog.BlogId);
            if (item is null)
            {
                model = new BlogMessageResponseModel()
                {
                    IsSuccess = false,
                    Message = "No data found."
                };
                return Json(model);
            }

            _context.Blogs.Remove(item);
            int result = _context.SaveChanges();
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            model = new BlogMessageResponseModel()
            {
                IsSuccess = result > 0,
                Message = message
            };
            return Json(model);
        }
    }
}
