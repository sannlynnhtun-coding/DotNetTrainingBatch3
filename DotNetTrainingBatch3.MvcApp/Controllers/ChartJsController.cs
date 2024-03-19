using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    public class ChartJsController : Controller
    {
        public IActionResult BarChart()
        {
            return View();
        }
    }
}
