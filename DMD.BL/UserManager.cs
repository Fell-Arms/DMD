using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DMD.BL;
using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using DMD.BL.Models;
using Microsoft.Extensions.Logging;
using System.Transactions;

namespace DMD.BL
{
    public class LoginFailureException : Exception
    {
        public LoginFailureException() : base("Cannot log in with these credentials.  Your IP address has been saved.")
        {
        }
        public LoginFailureException(string message) : base(message)
        {
        }
    }
    public static class UserManager
    {
        private static string GetHash(string password)
        {
            using (var hash = SHA1.Create())
            {
                var hashbytes = Encoding.UTF8.GetBytes(password);
                return Convert.ToBase64String(hash.ComputeHash(hashbytes));
            }
        }


        public static int DeleteAll()
        {
            try
            {
                using (DMDEntities dc = new DMDEntities())
                {
                    dc.tblUsers.RemoveRange(dc.tblUsers.ToList());
                    return dc.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        //Users Insert Method
        public static int Insert(User user, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DMDEntities dc = new DMDEntities())
                {
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblUser row = new tblUser();
                    // Set the properties
                    // Use a Ternary operator (if else in 1 line.)
                    //row.Id = dc.tblUsers.Any() ? dc.tblUsers.Max(s => s.Id) + 1 : 1; //NEEDS TO BE LOOKED AT
                    
                    row.Id = Guid.NewGuid();
                    row.FirstName = user.FirstName;
                    row.LastName = user.LastName;
                    row.Username = user.UserName;
                    row.Email = user.Email;
                    row.Password = user.Password; //getHash goes back here later(?)
                    dc.tblUsers.Add(row);
                    results = dc.SaveChanges();
                    if (rollback) transaction.Rollback();
                    // IMPORTANT!!!!!!
                    // Backfill the id on the object that is passed in the parameters.
                    user.Id = row.Id;
                    return results;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Users Update Method
        //Updates data via instance of table
        public static int Update(User user, bool rollback = false)
        {
            try
            {
                //Sets int results to a value of 0
                int results = 0;

                using (DMDEntities dc = new DMDEntities())
                {
                    //Sets context transaction to null and checks if to begin a transaction
                    IDbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    //Get current row from user User Table.
                    tblUser row = dc.tblUsers.Where(dt => dt.Id == user.Id).FirstOrDefault();

                    //Set the data for the new row in User Table
                    row.Id = user.Id;
                    row.Username = user.UserName;
                    row.Password = user.Password;
                    row.Email = user.Email;
                    row.FirstName = user.FirstName;
                    row.LastName = user.LastName;

                    //Commit changes
                    results = dc.SaveChanges();

                    //Checks if Rollback is needed
                    if (rollback) transaction.Rollback();

                    //Returns the results
                    return results;

                }

            }
            catch (Exception ex)
            {
                //Log info
                throw ex;
            }

        }



        //Users Delete Method.
        public static int Delete(Guid id, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;
                using (DMDEntities dc = new DMDEntities())
                {
                    tblUser row = dc.tblUsers.FirstOrDefault(c => c.Id == id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) transaction = dc.Database.BeginTransaction();

                        dc.tblUsers.Remove(row); //Removes row based on ID Value in Row.
                        results = dc.SaveChanges(); //Saves changes to table
                        if (rollback) transaction.Rollback();
                    }
                    else
                    {
                        throw new Exception("Row was not found");
                    }
                    return results;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //Load Data Method.
        public static List<User> Load()
        {
            try
            {
                //Sets List of Users with the name of "rows" to the value of a list of Users.
                List<User> rows = new List<User>();
                using (DMDEntities dc = new DMDEntities())
                {
                    // select * from tblUsers
                    dc.tblUsers
                        .ToList()
                        .ForEach(dt => rows.Add(new User
                        {
                            Id = dt.Id,
                            UserName = dt.Username,
                            Password = dt.Password,
                            Email = dt.Email,
                            FirstName = dt.FirstName,
                            LastName = dt.LastName
                        }));
                    return rows;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //NEED TO FINISH FOR TESTING TO BE DONE.

        //Load By ID Method.
       /* public static User LoadById(Guid Id)
        {
            try
            {
                using (DMDEntities)
            }
        }
       */




        public static bool Login(User user)
        {
            try
            {
                if (!string.IsNullOrEmpty(user.UserName))
                {
                    if (!string.IsNullOrEmpty(user.Password))
                    {
                        using (DMDEntities dc = new DMDEntities())
                        {
                            tblUser tblUser = dc.tblUsers.FirstOrDefault(u => u.Username == user.UserName);
                            if (tblUser != null)
                            {
                                if (tblUser.Password == user.Password) //HASH LATER!
                                {
                                   // Back fill all the user data, if logged in succedes
                                    user.FirstName = tblUser.FirstName;
                                    user.LastName = tblUser.LastName;
                                    user.Id = tblUser.Id;
                                    return true;
                                }
                                else //NOT HASHED YET...
                                {
                                    throw new LoginFailureException();
                                }
                            }
                            else
                            {
                                throw new Exception("UserId could not be found.");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Password was not set.");
                    }
                }
                else
                {
                    throw new Exception("UserId was not set.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Seed()
        {
            User user = new User
            {
                UserName = "bfoote",
                FirstName = "Brian",
                Email = "test@test.com",
                LastName = "Foote",
                Password = "maple"
            };
            Insert(user);
            user = new User
            {
                UserName = "ketchum",
                FirstName = "Ash",
                Email = "ashketchum@test.com",
                LastName = "Ketchum",
                Password = "maple"
            };
            Insert(user);
        }
    }
}