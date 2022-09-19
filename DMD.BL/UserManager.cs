﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DMD.BL;
using DMD.PL;
using Microsoft.EntityFrameworkCore.Storage;
using DMD.BL.Models;


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





        //public static int Insert(User user, bool rollback = false)
        //{
        //    try
        //    {
        //        int results = 0;
        //        using (DMDEntities dc = new DMDEntities())
        //        {
        //            IDbContextTransaction transaction = null;
        //            if (rollback) transaction = dc.Database.BeginTransaction();
        //            tblUser row = new tblUser();
        //            // Set the properties
        //            // Use a Ternary operator (if else in 1 line.)
        //            row.Id = dc.tblUsers.Any() ? dc.tblUsers.Max(s => s.Id) + 1 : 1; //NEEDS TO BE LOOKED AT
        //            row.FirstName = user.FirstName;
        //            row.LastName = user.LastName;
        //            row.Username = user.UserName;
        //            row.Password = GetHash(user.Password);
        //            dc.tblUsers.Add(row);
        //            results = dc.SaveChanges();
        //            if (rollback) transaction.Rollback();
        //            // IMPORTANT!!!!!!
        //            // Backfill the id on the object that is passed in the parameters.
        //            user.Id = row.Id;
        //            return results;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
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
                                if (tblUser.Password == GetHash(user.Password))
                                {
                                    // Back fill all the user data, if logged in succedes
                                    user.FirstName = tblUser.FirstName;
                                    user.LastName = tblUser.LastName;
                                    user.Id = tblUser.Id;
                                    return true;
                                }
                                else
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
    //    public static void Seed()
    //    {
    //        User user = new User
    //        {
    //            UserName = "bfoote",
    //            FirstName = "Brian",
    //            LastName = "Foote",
    //            Password = "maple"
    //        };
    //        Insert(user);
    //        user = new User
    //        {
    //            UserName = "ketchum",
    //            FirstName = "Ash",
    //            LastName = "Ketchum",
    //            Password = "maple"
    //        };
    //        Insert(user);
    //    }
    }
}