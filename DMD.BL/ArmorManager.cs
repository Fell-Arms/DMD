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

    public static class ArmorManager
    {
        


        public async static Task<List<Armor>> Load()
        {
            try
            {
                List<Armor> armors = new List<Armor>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblArmors
                            .ToList()
                            .ForEach(a => armors.Add(new Armor()
                            {
                                Id = a.Id,
                                ArmorStyle_Id = a.ArmorStyle_Id,
                                ArmorType_Id = a.ArmorType_Id,
                                Name = a.Name,
                                ArmorClassBonus = a.ArmorClassBonus,
                                MovementPenalty = a.MovementPenalty,    
                                Cost = a.Cost,  
                               
                            }));
                    }
                });
                return armors;
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

