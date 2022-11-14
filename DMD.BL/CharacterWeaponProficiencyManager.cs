using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterWeaponProficiencyManager
    {
        public async static Task<int> Insert(Guid characterId, Guid weaponTypeId, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterWeaponTypeProficiency tblCharacterWeaponTypeProficiency = new();
                        tblCharacterWeaponTypeProficiency.Id = Guid.NewGuid();
                        tblCharacterWeaponTypeProficiency.Character_Id = characterId;
                        tblCharacterWeaponTypeProficiency.WeaponType_Id = weaponTypeId;

                        dc.tblCharacterWeaponTypeProficiencies.Add(tblCharacterWeaponTypeProficiency);

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
