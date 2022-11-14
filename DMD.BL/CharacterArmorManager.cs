using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMD.BL
{
    public class CharacterArmorManager
    {
        public async static Task<int> Insert(Guid characterId, Guid armorId, bool equipped = false, bool rollback = false)
        {
            try
            {
                int results = 0;

                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        IDbContextTransaction transaction = dc.Database.BeginTransaction();
                        tblCharacterArmor tblCharacterArmor = new();
                        tblCharacterArmor.Id = Guid.NewGuid();
                        tblCharacterArmor.Character_Id = characterId;
                        tblCharacterArmor.Armor_Id = armorId;
                        tblCharacterArmor.Equipped = equipped; 

                        dc.tblCharacterArmors.Add(tblCharacterArmor);

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
