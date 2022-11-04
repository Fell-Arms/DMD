//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DMD.BL.Models;
//using DMD.PL;

//namespace DMD.BL
//{
//    public asy class ClassesManager
//    {
//        public static List<Class> Load()
//        {
//            try
//            {
//                List<Class> rows = new List<Class>();

//                using (DMDEntities am = new DMDEntities())
//                {
//                    //SELECT * FROM tblDegreeType and put into list

//                    am.tblClasses
//                        .ToList()
//                        .ForEach(am => rows.Add(new Class
//                        {
//                            Id = am.Id,
//                            Name = am.Name,
//                            Description = am.Description,
//                            HPUpDieOnLevel = am.HPUpDieOnLevel,
                            
//                        }));

//                    return rows;

//                }
//                //the dc is out of scope and will be disposed.
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }

//        }


//        public static Class LoadById(Guid id)
//        {
//            try
//            {
//                using (DMDEntities ch = new DMDEntities())
//                {
//                    tblClass row = ch.tblClasses.FirstOrDefault(am => am.Id == id);

//                    if (row != null)
//                    {
//                        return new Class
//                        {
//                            Id = row.Id,
//                            ClassType_Id = row.ClassType_Id,
//                            ClassClassBonus = row.ClassClassBonus,
//                            ClassStyle_Id = row.ClassStyle_Id,
//                            MovementPenalty = row.MovementPenalty,
//                            Cost = row.Cost

//                        };
//                    }
//                    else
//                    {
//                        throw new Exception("Row was not found.");
//                    }

//                }
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }

//        }



//    }
//}
