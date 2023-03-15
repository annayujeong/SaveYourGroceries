using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceries
{
    [TestClass]
    public class PriceUpdate
    {
        static string JSON_FILE_NAME = "SaveYourGroceries.json";
        static string savedListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), PriceUpdate.JSON_FILE_NAME);
        string savedItemsList = null;

        static string JSON_NEW_FILE_NAME = "SaveYourGroceries.json";
        static string newSavedListPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), PriceUpdate.JSON_NEW_FILE_NAME);
        string newItemsList = null;

        [TestMethod]
        public void Test001ReadSavedList()
        {
            string savedItemsList = File.ReadAllText(savedListPath); // TODO: in JSON
            this.savedItemsList = savedItemsList;
            Assert.IsNotNull(this.savedItemsList);
        }

        [TestMethod]
        public void Test002GetNewPrices()
        {
            // TODO: query store name & item name -> call webscraper & methods & put it in arraylist (newItemsList) ?
        }

        [TestMethod]
        public void Test003WriteUpdatedPrices()
        {
            using (StreamWriter writer = new StreamWriter(newSavedListPath))
            {
                writer.WriteLine("anna test");
            }
            // Read a file
            string readText = File.ReadAllText(savedListPath); // TODO: in JSON
            Console.WriteLine(readText);
        }

        [TestMethod]
        public void Test000()
        {
            Console.WriteLine("hi from anna");
            Assert.Fail();
        }
    }
}
