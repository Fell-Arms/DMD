using Microsoft.AspNetCore.Mvc;

namespace DMD.UI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
