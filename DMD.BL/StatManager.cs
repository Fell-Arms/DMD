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

    public static class StatManager
    {
        public async static Task<List<Stat>> Load()
        {
            try
            {
                List<Stat> stats = new List<Stat>();
                await Task.Run(async () =>
                {
                    using (DMDEntities st = new DMDEntities())
                    {
                        foreach (tblStat s in st.tblStats.ToList())
                        {
                            Stat stat = new Stat
                            {
                                Id = s.Id,
                                Name = s.Name,
                                Description = s.Description,

                            };

                            stats.Add(stat);
                        }
                    }
                });
                return stats;
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

