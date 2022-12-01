using Castle.Core.Resource;
using DMD.BL;
using DMD.BL.Models;
using DMD.UI.Extensions;
using DMD.UI.Models;
using DMD.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using System.Data;

namespace DMD.UI.Controllers
{
    public class AccountController : Controller
    {

        // GET: AccountController
        public ActionResult Index(string returnUrl)
        {
            //if(isLoggedIn)
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                TempData["returnurl"] = returnUrl;
                User user = HttpContext.Session.GetObject<User>("user");

                AccountViewModel accountViewModel = new AccountViewModel();
                accountViewModel.User = user;

                //-------------Load lists for display menus-----------\\

                accountViewModel.userCharacters = CharacterManager.LoadByUserId(user.Id).Result;
                //accountViewModel.myMaps = MapManager.Load().Result;

                return View(accountViewModel);

            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
