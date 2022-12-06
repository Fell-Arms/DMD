using DMD.BL.Models;
using DMD.PL;

namespace DMD.BL
{

    public static class MapsManager
    {
        //public async static Task<List<Map>> Load()
        //{
        //    try
        //    {
        //        List<Map> maps = new List<Map>();
        //        await Task.Run(() =>
        //        {
        //            using (DMDEntities ra = new DMDEntities())
        //            {
        //                foreach (tblMap r in ra.tblMaps.ToList())
        //                {
        //                    Map map = new Map
        //                    {
        //                        Id = r.Id,
        //                        Name = r.Name,
        //                        Description = r.Description,
        //                    };

        //                    maps.Add(map);
        //                }
        //            }
        //        });
        //        return maps;
        //    }

        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        public async static Task<List<Map>> Load()
        {
            try
            {
                List<Map> maps = new List<Map>();
                await Task.Run(() =>
                {
                    using (DMDEntities dc = new DMDEntities())
                    {
                        dc.tblMaps
                            .ToList()
                            .ForEach(m => maps.Add(new Map()
                            {
                                Id = m.Id,
                                Type = m.Type,
                                ImagePath = m.ImagePath
                            }));
                    }
                });
                return maps;
            }

            catch (Exception)
            {

                throw;
            }

        }


        public static Map LoadById(Guid id)
        {
            try
            {
                using (DMDEntities dc = new DMDEntities())
                {
                    tblMap row = dc.tblMaps.FirstOrDefault(m => m.Id == id);

                    if (row != null)
                    {
                        return new Map
                        {
                            Id = row.Id,
                            Type = row.Type,
                            ImagePath = row.ImagePath

                        };
                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
    }
}


