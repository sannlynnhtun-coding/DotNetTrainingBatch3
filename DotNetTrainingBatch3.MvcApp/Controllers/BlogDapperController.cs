using DotNetTrainingBatch3.MvcApp.Models;
using DotNetTrainingBatch3.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    public class BlogDapperController : Controller
    {
        private readonly DapperService _dapperService;

        public BlogDapperController(DapperService dapperService)
        {
            _dapperService = dapperService;
        }

        public IActionResult Index()
        {
            var lst = _dapperService.Query<BlogModel>("select * from tbl_blog");
            return View(lst);
        }
    }
}
