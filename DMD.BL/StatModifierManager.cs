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

    public static class StatModifierManager
    {
        //public async static Task<List<StatModifier>> Load()
        //{
        //    try
        //    {
        //        List<StatModifier> statModifiers = new List<StatModifier>();
        //        await Task.Run(async () =>
        //        {
        //            using (DMDEntities sta = new DMDEntities())
        //            {
        //                foreach (tblStatModifier s in sta.tblStatModifiers.ToList())
        //                {
        //                    StatModifier statModifier = new StatModifier
        //                    {
        //                       Value = s.Value,
        //                       Modifier = s.Modifier 

        //                    };

        //                    statModifiers.Add(statModifier);
        //                }
        //            }
        //        });
        //        return statModifiers;
        //    }

        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}



        public async static Task<List<StatModifier>> Load()
        {
            try
            {
                List<StatModifier> statModifiers = new List<StatModifier>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblStatModifiers
                            .ToList()
                            .ForEach(s => statModifiers.Add(new StatModifier()
                            {
                               Value = s.Value,
                               Modifier = s.Modifier

                            }));
                    }
                });
                return statModifiers;
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

