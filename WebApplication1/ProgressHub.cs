using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class ProgressHub : Hub
    {
        public void NotifyStart(string connectionId)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
            hubContext.Clients.Client(connectionId).initProgressBar(connectionId);
        }

        public void NotifyProgress(string connectionId, int percentage)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
            hubContext.Clients.Client(connectionId).updateProgressBar(connectionId, percentage);
        }

        public void NotifyEnd(string connectionId)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
            hubContext.Clients.Client(connectionId).clearProgressBar(connectionId);
        }
    }
}