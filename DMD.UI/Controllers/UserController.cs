using DMD.BL;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using DMD.BL.Models;
using Microsoft.AspNetCore.Mvc;
using DMD.UI.Extensions;

namespace DMD.UI.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Seed()
        {
            UserManager.Seed();
            return View();
        }
        public ActionResult Login(string returnUrl)
        {
            TempData["returnurl"] = returnUrl;
            return View();
        }
        private void SetUser(User user)
        {
            HttpContext.Session.SetObject("user", user);
            if (user != null)
            {
                HttpContext.Session.SetObject("fullname", user.FullName);
            }
            else
            {
                HttpContext.Session.SetObject("fullname", string.Empty);
            }
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                UserManager.Login(user);
                SetUser(user);
                if (TempData["returnurl"] != null)
                {
                    return Redirect(TempData["returnurl"]?.ToString());
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(user);
            }
        }
        public ActionResult Logout()
        {
            SetUser(null);
            return View();
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            User user = new User(); //New instance of user
            return View(user);
        }
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                UserManager.Insert(user);
                if (TempData["returnurl"] != null)
                {
                    var returnurl = TempData["returnurl"];
                    TempData["returnurl"] = null;
                    return Redirect(returnurl?.ToString()); // Should make returnurl null after redirecting so it doesn't hijack their redirect later on
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: UserController/Edit/5
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
        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: UserController/Delete/5
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

