using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quartz;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveYourGroceries
{
    /// <summary>
    /// Author: Anna
    /// Contain reading saved item json file and get new prices.
    /// Send a notification If lower prices are found.
    /// </summary>
    public class PriceUpdate: IJob
    {
        List<Item> savedItems = null;
        List<Item> updatedItems = null;

        JSONParser parser = new JSONParser();
        WebScraper webScraper = new WebScraper();

        //TODO: can be deleted in the future
        private string testJSON = "[{\"name\":\"Apple\",\"price\":\"3.45\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg\",\"store\":\"Superstore\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Pear\",\"price\":\"4.56\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg\",\"store\":\"Save on Foods\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Strawberries\",\"price\":\"9.43\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg\",\"store\":\"Walmart\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"}]";

        /// <summary>
        /// Combine and execute all functions needed to push notification.
        /// </summary>
        /// <param name="context">IJobExecutionContext</param>
        /// <returns>CompletedTask</returns>
        public async Task Execute(IJobExecutionContext context)
        {
            ReadSavedList();
            GetNewPrices();
            PushNotificationOnLowerPriceFound();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Read saved list json file and store it in a list.
        /// </summary>
        public void ReadSavedList()
        {
            savedItems = parser.deserializeItems();
            foreach (var item in savedItems)
            {
                Console.WriteLine(item.name);
            }
            Assert.IsNotNull(this.savedItems);
        }

        /// <summary>
        /// Loop through the list, get new prices for the items and save in a list.
        /// </summary>
        public void GetNewPrices()
        {
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

        /// <summary>
        /// Push notification if lower price of the item is found.
        /// </summary>
        public void PushNotificationOnLowerPriceFound()
        {
            for (int index = 0; index < updatedItems.Count; index++)
            {
                Item updatedItem = updatedItems[index];
                Item savedItem = savedItems[index];

                if (int.Parse(updatedItem.price) < int.Parse(savedItem.price))
                {
                    new ToastContentBuilder()
                         .AddHeader("header", "New Price Found!", "")
                         .AddText("We found your saved item " + savedItem.name
                                  + " with $"
                                  + (int.Parse(savedItem.price) - int.Parse(updatedItem.price))
                                  + " lower price")
                         .Show();
                }
            }
        }
    }
}
