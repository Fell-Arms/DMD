using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMD.UI.Controllers
{
    public class SheetsController : Controller
    {
        // GET: SheetsController
        public ActionResult Index()
        {
            return View();
        }
    }
}
