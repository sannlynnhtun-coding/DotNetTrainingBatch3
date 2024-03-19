using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    public class CanvasJsController : Controller
    {
        public IActionResult BarChart()
        {
            return View();
        }
    }
}
