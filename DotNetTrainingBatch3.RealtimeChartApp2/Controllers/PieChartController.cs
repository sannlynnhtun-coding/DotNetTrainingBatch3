using DotNetTrainingBatch3.RealtimeChartApp2.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace DotNetTrainingBatch3.RealtimeChartApp2.Controllers
{
    public class PieChartController : Controller
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public PieChartController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public static List<PieChartModel> Data = new List<PieChartModel>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(PieChartModel requestModel)
        {
            Data.Add(requestModel);

            PieChartResponseModel model = new PieChartResponseModel()
            {
                Labels = Data.Select(x => x.Label).ToList(),
                Series = Data.Select(x => x.Series).ToList(),
            };

            string json = JsonConvert.SerializeObject(model);
            await _hubContext.Clients.All.SendAsync("ClientReceiveEvent", json);
            return View();
        }

        public IActionResult Watch()
        {
            return View();
        }
    }

    public class PieChartModel
    {
        public string Label { get; set; }
        public int Series { get; set; }
    }

    public class PieChartResponseModel
    {
        public List<string> Labels { get; set; }
        public List<int> Series { get; set; }
    }
}
