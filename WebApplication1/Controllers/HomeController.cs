using System.Web.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task StartProgress([Bind(Prefix = "id")] string connectionId)
        {
            var hub = new ProgressHub();
            hub.NotifyStart(connectionId);

            for (int i = 0; i <= 100; i += 5)
            {
                hub.NotifyProgress(connectionId, i);
                await Task.Delay(100);
            }

            hub.NotifyEnd(connectionId);
        }
    }
}