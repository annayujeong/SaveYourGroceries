using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.IO;

namespace SaveYourGroceries
{
    [TestClass]
    public class PriceUpdate
    {
        List<Item> savedItems = null;
        List<Item> updatedItems = null;

        JSONParser parser = new JSONParser();

        //TODO: can be deleted in the future
        private string testJSON = "[{\"name\":\"Apple\",\"price\":\"3.45\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg\",\"store\":\"Superstore\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Pear\",\"price\":\"4.56\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg\",\"store\":\"Save on Foods\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Strawberries\",\"price\":\"9.43\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg\",\"store\":\"Walmart\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"}]";

        [TestMethod]
        public void Test001ReadSavedList()
        {
            savedItems = parser.deserializeItems();
            foreach (var item in savedItems)
            {
                Console.WriteLine(item.name);
            }
            Assert.IsNotNull(this.savedItems);
        }

        [TestMethod]
        public void Test002GetNewPrices()
        {
            WebScraper webScraper = new WebScraper();
            foreach (var item in savedItems)
            {
                switch (item.store)
                {
                    case "Save on Foods":
                        updatedItems.Add(webScraper.SearchItemSaveOnFoods(item.name)); break;
                    case "Walmart":
                        updatedItems.Add(webScraper.SearchItemWalmart(item.name)); break;
                    case "T and T":
                        updatedItems.Add(webScraper.SearchItemsTandT(item.name)); break;
                    case "Superstore":
                        updatedItems.Add(webScraper.SearchItemSuperstore(item.name)); break;
                }
            }
            webScraper.driver.Quit();
        }

        [TestMethod]
        public void Test003WriteUpdatedPrices()
        {
            parser.serializeItems(updatedItems, Constants.JSON_UPDATED_FILE_LOCATION);
        }

        // if we want to use SaveYourGroceries Settings.settings,
        // get Settings.Default.notificationCheckboxStatus
        [TestMethod]
        public void Test004PushNotificationOnLowerPriceFound()
        {
            bool isNotificationOn = Convert.ToBoolean(File.ReadAllText(Constants.NOTI_TXT_FILE_LOCATION));
            if (!isNotificationOn)
            {
                return;
            }

            for (int index = 0; index < updatedItems.Count; index++)
            {
                Item updatedItem = updatedItems[index];
                Item savedItem = savedItems[index];

                if (int.Parse(updatedItem.price) < int.Parse(savedItem.price))
                {
                    new ToastContentBuilder()
                         .AddHeader("header", "New Price Found!", "TODO")
                         .AddText("We found your saved item " + savedItem.name
                                  + " with $"
                                  + (int.Parse(savedItem.price) - int.Parse(updatedItem.price))
                                  + " lower price")
                         .Show();
                }
            }
        }

        //[TestMethod]
        //public void Test000()
        //{
        //    Console.WriteLine("hi from anna");
        //    Assert.Fail();
        //}
    }
}
