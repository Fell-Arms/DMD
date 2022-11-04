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

    public static class ClassesManager
    {
        public async static Task<List<Class>> Load()
        {
            try
            {
                List<Class> classes = new List<Class>();
                await Task.Run(async () =>
                {
                    using (DMDEntities ca = new DMDEntities())
                    {
                        foreach (tblClass c in ca.tblClasses.ToList())
                        {
                            Class class1 = new Class
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Description = c.Description,
                                HPUpDieOnLevel = c.HPUpDieOnLevel,

                            };

                            classes.Add(class1);
                        }
                    }
                });
                return classes;
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

