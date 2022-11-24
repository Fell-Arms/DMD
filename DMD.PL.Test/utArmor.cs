
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Storage;
using DMD.PL;
using Assert = NUnit.Framework.Assert; //May need to keep.

namespace DMD.PL.Test
{
    [TestClass]
    public class utArmor
    {
        //Protected entities instances for the Test to use
        protected DMDEntities dc;
        protected IDbContextTransaction transaction;

        //Initialization Test Method for PL
        [TestInitialize]
        public void TestInitialize()
        {
            dc = new DMDEntities();                         //Instantiates DMDEntities Data for context for PL.
            transaction = dc.Database.BeginTransaction();   //Instantiates transaction process for the database.
        }

        //Test Cleanup Method
        [TestCleanup]
        public void TestCleanup()
        {
            transaction.Rollback();     //Rollback transactions
            transaction.Dispose();      //Dispose of the transactions
            dc.Dispose();               //Dispose the data context from the PL.
        }

        //Load Test Method
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(3, dc.tblArmors.Count());
        }

        //Insert Test Method
        [TestMethod]
        public void InsertTest()
        {
            //Creates new instance of table and adds a value for each column for the row to be inserted.
            tblArmor armor = new tblArmor();
            armor.Id = Guid.NewGuid();                                                                  //NEEDS TO BE EXISTING ID'S
            armor.ArmorStyle_Id = Guid.NewGuid();                                                       //Need to point to foreign keys that exist. //NEEDS TO BE SIMILAR TO THE existingRow example from below.
            armor.ArmorType_Id = Guid.NewGuid();
            armor.Name = "New armor";
            armor.ArmorClassBonus = 100;
            armor.MovementPenalty = 100;
            armor.Cost = 100;

            //Add new row and saves changes
            dc.tblArmors.Add(armor);
            int result = dc.SaveChanges();

            //Asserts that the value of result is greater than 0, indicating a proper save.
            Assert.IsTrue(result > 0);
        }

        //Update Test Method
        [TestMethod]
        public void UpdateTest()
        {
            InsertTest(); //Runs insert test method.

            tblArmor existingRow = dc.tblArmors.FirstOrDefault(c => c.Cost == 100);                     //THIS IS WHAT SHOULD BE REFERENCED ON HOW TO IMPLEMENT FOREIGN KEY CONNECTION.

            if(existingRow != null) 
            {
                existingRow.Id = Guid.NewGuid();
                existingRow.ArmorStyle_Id = Guid.NewGuid();
                existingRow.ArmorType_Id = Guid.NewGuid();
                existingRow.Name = "Recon Armor";
                existingRow.ArmorClassBonus = 200;
                existingRow.MovementPenalty = 200;
                existingRow.Cost = 200;
            }

            tblArmor row = dc.tblArmors.FirstOrDefault(c => c.Cost == 200);
            Assert.AreEqual(existingRow.Cost, row.Cost);          
        }
    }
}