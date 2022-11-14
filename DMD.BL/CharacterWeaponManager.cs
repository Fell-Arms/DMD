using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterWeaponManager
    {
        public async static Task<int> Insert(Guid characterId, Guid weaponId, bool equipped = false, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterWeapon tblCharacterWeapon = new();
                        tblCharacterWeapon.Id = Guid.NewGuid();
                        tblCharacterWeapon.Character_Id = characterId;
                        tblCharacterWeapon.Weapon_Id = weaponId;
                        tblCharacterWeapon.Equipped = equipped;

                        dc.tblCharacterWeapons.Add(tblCharacterWeapon);

                        results = dc.SaveChanges();
                        if (rollback) { transaction.Rollback(); }
                        else { transaction.Commit(); }
                    }
                });

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
