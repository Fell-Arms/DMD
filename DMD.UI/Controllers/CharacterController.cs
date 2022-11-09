using DMD.BL;
using DMD.BL.Models;
using DMD.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using System.Data;

namespace DMD.UI.Controllers
{
    public class CharacterController : Controller
    {
        //// GET: CharacterController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: CharacterController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: CharacterController/Create
        public ActionResult Create()
        {
            CharacterViewModel characterViewModel = new CharacterViewModel();
            characterViewModel.Character = new Character();


            //-------------Need to load lists for dropdown menus-----------\\

            characterViewModel.Languages = LanguageManager.Load().Result;
            characterViewModel.Classes = ClassesManager.Load().Result;
            characterViewModel.Stats = StatManager.Load().Result;
            characterViewModel.Races = RacesManager.Load().Result;
            characterViewModel.Weapons = WeaponManager.Load().Result;
            characterViewModel.Armors = ArmorManager.Load().Result;


            return View(characterViewModel);
            //return View();
        }

        // POST: CharacterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterViewModel characterViewModel)
        {
            try
            {


                CharacterManager.Insert(characterViewModel.Character);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(characterViewModel);
            }
        }

        //// GET: CharacterController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CharacterController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: CharacterController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: CharacterController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
