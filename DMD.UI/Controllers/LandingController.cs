using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMD.UI.Controllers
{
    public class LandingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
