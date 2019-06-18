using System.Web.Mvc;
using System.Threading;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void StartProgress([Bind(Prefix = "id")] string connectionId)
        {
            var hub = new ProgressHub();

            hub.NotifyStart(connectionId);


            // updating client progress
            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 10);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 20);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 30);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 40);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 50);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 60);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 70);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 80);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 90);

            Thread.Sleep(1000);
            hub.NotifyProgress(connectionId, 100);


            Thread.Sleep(1000);
            hub.NotifyEnd(connectionId);
        }
    }
}