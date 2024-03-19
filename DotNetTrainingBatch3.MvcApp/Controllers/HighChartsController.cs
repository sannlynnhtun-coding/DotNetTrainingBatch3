using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult DonutChart()
        {
            return View();
        }
    }
}
