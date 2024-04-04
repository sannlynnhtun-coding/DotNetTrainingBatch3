using DotNetTrainingBatch3.RealtimeChartApp.Hubs;
using DotNetTrainingBatch3.RealtimeChartApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DotNetTrainingBatch3.RealtimeChartApp.Controllers
{
    public class ChartController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHubContext<NotificationHub> _hubContext;

        public ChartController(AppDbContext appDbContext, IHubContext<NotificationHub> hubContext)
        {
            _appDbContext = appDbContext;
            _hubContext = hubContext;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PieChartModel requestModel)
        {
            TblPieChart chart = new TblPieChart()
            {
                PieChartLabel = requestModel.Label,
                PieChartSeries = requestModel.Series,
            };
            await _appDbContext.AddAsync(chart);
            await _appDbContext.SaveChangesAsync();

            var model = await Get();
            var json = JsonConvert.SerializeObject(model);
            await _hubContext.Clients.All.SendAsync("ClientNotification", json);

            return View();
        }

        public async Task<IActionResult> Watch()
        {
            var model = await Get();
            return View(model);
        }

        private async Task<PieChartResponseModel> Get()
        {
            var result = await _appDbContext.TblPieCharts.ToListAsync();
            var model = new PieChartResponseModel
            {
                Labels = result.Select(x => x.PieChartLabel).ToList(),
                Series = result.Select(x => x.PieChartSeries).ToList()
            };
            return model;
        }
    }
}
