using DMD.BL.Models;
using DMD.PL;

namespace DMD.BL
{

    public static class RacesManager
    {
        //public async static Task<List<Race>> Load()
        //{
        //    try
        //    {
        //        List<Race> races = new List<Race>();
        //        await Task.Run(() =>
        //        {
        //            using (DMDEntities ra = new DMDEntities())
        //            {
        //                foreach (tblRace r in ra.tblRaces.ToList())
        //                {
        //                    Race race = new Race
        //                    {
        //                        Id = r.Id,
        //                        Name = r.Name,
        //                        Description = r.Description,
        //                    };

        //                    races.Add(race);
        //                }
        //            }
        //        });
        //        return races;
        //    }

        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        public async static Task<List<Race>> Load()
        {
            try
            {
                List<Race> races = new List<Race>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblRaces
                            .ToList()
                            .ForEach(r => races.Add(new Race()
                            {
                                Id = r.Id,
                                Name = r.Name,
                                Description = r.Description
                            }));
                    }
                });
                return races;
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

