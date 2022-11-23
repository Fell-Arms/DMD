using Castle.Core.Resource;
using DMD.BL;
using DMD.BL.Models;
using DMD.UI.Extensions;
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



        private void SetUser(User user)
        {
            HttpContext.Session.SetObject("user", user);
            if (user != null)
            {
                HttpContext.Session.SetObject("UserId", user.Id);
            }
            else
            {
                HttpContext.Session.SetObject("UserId", string.Empty);
            }
        }


        public ActionResult Create()
        {
            CharacterViewModel characterViewModel = new CharacterViewModel();
            characterViewModel.Character = new Character();

            //characterViewModel.Stats = StatManager.Load().Result;
            //ViewData["Stats"] = characterViewModel.Stats;

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
                //characterViewModel.Character.RaceId = characterViewModel.Race.Id;
                

                CharacterManager.Insert(characterViewModel.Character);
                Guid characterId = characterViewModel.Character.Id;

                //foreach(var stat in characterViewModel.CharacterStats)
                //{
                //    CharacterStatsManager.Insert(characterId, stat.Id, stat.Value);
                //}

                for (int i = 0; i < characterViewModel.CharacterStatIds.Count(); i++)
                { 
                    Guid statId= characterViewModel.CharacterStatIds[i];
                    int value= characterViewModel.CharacterStatValues[i];
                    //CharacterStatsManager.Insert(characterId, statId, value);
                    int randomNum = 0;
                }

                return RedirectToAction("Index", "Home");

                /*
                 *  StudentManager.Insert(studentAdvisors.Student);
                    int id = studentAdvisors.Student.Id;

                    // Convey changes to the database
                    studentAdvisors.AdvisorIds.ToList().ForEach(a => StudentAdvisorManager.Insert(id, a));
                 * 
                 * 
                 */
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
