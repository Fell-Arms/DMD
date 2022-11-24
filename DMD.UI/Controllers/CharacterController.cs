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

        //GET: CharacterController/Create
        public ActionResult Create(string returnUrl)
        {
            //if(isLoggedIn)
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                TempData["returnurl"] = returnUrl;
                User user = HttpContext.Session.GetObject<User>("user");

                CharacterViewModel characterViewModel = new CharacterViewModel();
                characterViewModel.Character = new Character();
                characterViewModel.Character.UserId = user.Id;
                characterViewModel.User = user;

                //characterViewModel.Stats = StatManager.Load().Result;
                //ViewData["Stats"] = characterViewModel.Stats;

                //-------------Need to load lists for dropdown menus-----------\\

                characterViewModel.Languages = LanguageManager.Load().Result;
                characterViewModel.Classes = ClassesManager.Load().Result;
                characterViewModel.Stats = StatManager.Load().Result;
                characterViewModel.Races = RacesManager.Load().Result;
                characterViewModel.Weapons = WeaponManager.Load().Result;
                characterViewModel.Armors = ArmorManager.Load().Result;
                characterViewModel.Currency = CurrencyManager.Load().Result;
                
                foreach ( var currency in characterViewModel.Currency)
                {

                }


                return View(characterViewModel);

            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
            //return View();
        }

        // POST: CharacterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharacterViewModel characterViewModel)
        {
            try
            {
                User user = HttpContext.Session.GetObject<User>("user");

                //characterViewModel.Character.RaceId = characterViewModel.Race.Id;
                //characterViewModel.Character.CharacterLevel = 1;
                characterViewModel.Character.UserId = user.Id;

                _ = CharacterManager.Insert(characterViewModel.Character).Result;
                Guid characterId = characterViewModel.Character.Id;

                //foreach(var stat in characterViewModel.CharacterStats)
                //{
                //    CharacterStatsManager.Insert(characterId, stat.Id, stat.Value);
                //}

                _ = CharacterClassesManager.Insert(characterId, characterViewModel.ClassId, characterViewModel.Character.CharacterLevelId);

                if( characterViewModel.CharacterStatIds != null)
                {
                    for (int i = 0; i < 6; i++)
                    { 
                        Guid statId= characterViewModel.CharacterStatIds[i];
                        int value= characterViewModel.CharacterStatValues[i];
                        _ = CharacterStatsManager.Insert(characterId, statId, value);
                        //int randomNum = 0;
                    }
                }

                if (characterViewModel.SelectedLanguageIds != null)
                {
                    foreach(Guid languageId in characterViewModel.SelectedLanguageIds)
                    {
                       _ = CharacterLanguagesManager.Insert(characterId, languageId);
                    }
                }

                if( characterViewModel.SelectedWeaponIds != null)
                {
                    foreach(Guid weaponId in characterViewModel.SelectedWeaponIds)
                    {
                      _ =  CharacterWeaponManager.Insert(characterId, weaponId);
                    }
                }

                if( characterViewModel.SelectedArmorIds != null)
                {
                    foreach(Guid armorId in characterViewModel.SelectedArmorIds)
                    {
                      _ = CharacterArmorManager.Insert(characterId, armorId);
                    }
                }

                if( characterViewModel.CharacterCurrencyIds != null)
                {
                    for(int i = 0; i < characterViewModel.CharacterCurrencyIds.Count(); i++)
                    {
                        Guid currencyId = characterViewModel.CharacterCurrencyIds[i];
                        int amount = characterViewModel.CharacterCurrencyAmounts[i];
                        _ = CharacterCurrencyManager.Insert(characterId, currencyId, amount);
                    }
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
