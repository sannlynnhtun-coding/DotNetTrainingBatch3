using Microsoft.AspNetCore.SignalR;

namespace DotNetTrainingBatch3.RealtimeChartApp.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task ServerNotification(string data)
        {
            await Clients.All.SendAsync("ClientNotification", data);
        }
    }
}
