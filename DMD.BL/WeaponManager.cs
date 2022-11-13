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

    public static class WeaponManager
    {
        //public async static Task<List<Weapon>> Load()
        //{
        //    try
        //    {
        //        List<Weapon> weapons = new List<Weapon>();
        //        await Task.Run(async () =>
        //        {
        //            using (DMDEntities wa = new DMDEntities())
        //            {
        //                foreach (tblWeapon w in wa.tblWeapons.ToList())
        //                {
        //                    Weapon weapon = new Weapon
        //                    {
        //                        Id = w.Id,
        //                        WeaponType_Id = w.WeaponType_Id,    
        //                        Stats_Id = w.Stats_Id,
        //                        Name = w.Name,
        //                        Cost = w.Cost

                             

        //                    };

        //                    weapon.WeaponDamageType_Ids = new List<Guid>();

        //                    foreach (tblWeaponDamageType wdt in w.tblWeaponDamageTypes.ToList())
        //                    {


        //                        WeaponDamageTypes weaponDamageTypes = new WeaponDamageTypes();
        //                        {
                                    

        //                        }
                            


        //                    }




        //                    weapons.Add(weapon);
        //                }
        //            }
        //        });
        //        return weapons;
        //    }

        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}


        public async static Task<List<Weapon>> Load()
        {
            try
            {
                List<Weapon> weapons = new List<Weapon>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblWeapons
                            .ToList()
                            .ForEach(w => weapons.Add(new Weapon()
                            {
                                Id = w.Id,
                                WeaponType_Id = w.WeaponType_Id,
                                Stats_Id = w.Stats_Id,
                                Name = w.Name,
                                Cost = w.Cost
                              

                            }));
                    }
                });
                return weapons;
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

