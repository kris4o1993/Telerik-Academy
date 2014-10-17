using System.Web.Mvc;

namespace MusicStore.Services.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
