using DMD.BL.Models;
using DMD.PL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{

    public static class LanguageManager
    {
        public async static Task<List<Language>> Load()
        {
            try
            {
                List<Language> languages = new List<Language>();
                await Task.Run(async () =>
                {
                    using (DMDEntities la = new DMDEntities())
                    {
                        foreach (tblLanguage l in la.tblLanguages.ToList())
                        {
                            Language language = new Language
                            {
                                Id = l.Id,
                                Name = l.Name,
                                Description = l.Description,

                            };

                            languages.Add(language);
                        }
                    }
                });
                return languages;
            }

            catch (Exception)
            {

                throw;
            }

        }


        //public static Armor LoadById(Guid id)
        //{
        //    try
        //    {
        //        using (DMDEntities dc = new DMDEntities())
        //        {
        //            tblArmor row = dc.tblArmors.FirstOrDefault(am => am.Id == id);

        //            if (row != null)
        //            {
        //                return new Armor
        //                {
        //                    Id = row.Id,
        //                    ArmorType_Id = row.ArmorType_Id,
        //                    ArmorClassBonus = row.ArmorClassBonus,
        //                    ArmorStyle_Id = row.ArmorStyle_Id,
        //                    MovementPenalty = row.MovementPenalty,
        //                    Cost = row.Cost

        //                };
        //            }
        //            else
        //            {
        //                throw new Exception("Row was not found.");
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}


    }
}

