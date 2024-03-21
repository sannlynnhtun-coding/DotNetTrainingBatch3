using DotNetTrainingBatch3.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace DotNetTrainingBatch3.MvcApp.Controllers
{
    public class ApexChartController : Controller
    {
        private readonly AppDbContext db;

        public ApexChartController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult PieChart()
        {
            ApexChartPieChartResponseModel model = new ApexChartPieChartResponseModel()
            {
                Lables = new List<string> { "Team A", "Team B", "Team C", "Team D", "Team E" },
                Series = new List<int> { 44, 55, 13, 43, 22 }
            };
            return View(model);
        }

        public IActionResult DashedLineChart()
        {
            var lst = db.PageStatistics.ToList();
            ApexChartDashedLineResponseModel model = new ApexChartDashedLineResponseModel();
            List<ApexChartDashedLineModel> lstSeries = new List<ApexChartDashedLineModel>();

            var lstSessionDuration = lst.Select(x => x.SessionDuration).ToList();
            var lstPageViews = lst.Select(x => x.PageViews).ToList();
            var lstTotalVisits = lst.Select(x => x.TotalVisits).ToList();
            var lstDate = lst.Select(x => x.CreatedDate).ToList();

            lstSeries.Add(new ApexChartDashedLineModel { name = "Session Duration", data = lstSessionDuration });
            lstSeries.Add(new ApexChartDashedLineModel { name = "Page Views", data = lstPageViews });
            lstSeries.Add(new ApexChartDashedLineModel { name = "Total Visits", data = lstTotalVisits });

            model.Series = lstSeries;
            model.Lables = lstDate;
            return View(model);
        }

        public IActionResult RadarChart()
        {
            var lst = db.Radars.ToList();

            ApexChartRadarResponseModel model = new ApexChartRadarResponseModel();
            model.Series = lst.Select(x => x.Series).ToList();
            model.Lables = lst.Select(x => x.Month).ToList();

            return View(model);
        }
    }
}
