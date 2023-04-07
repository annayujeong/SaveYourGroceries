using Microsoft.Toolkit.Uwp.Notifications;
using Quartz;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/// <summary>
/// Author: Anna
/// Contain reading saved item json file and get new prices.
/// Send a notification If lower prices are found.
/// </summary>
namespace SaveYourGroceries
{
    public class PriceUpdate: IJob
    {
        List<Item> savedItems = null;
        List<Item> updatedItems = new List<Item>();

        public List<Item> SavedItems { 
            get {  return savedItems; }
            set { savedItems = value; }
        }

        public List<Item> UpdatedItems { 
            get { return updatedItems; }
            set { updatedItems = value; }
        }

        JSONParser parser = new JSONParser();

        private string testJSON = "[{\"name\":\"Apple\",\"price\":\"3.45\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg\",\"store\":\"Superstore\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Pear\",\"price\":\"4.56\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg\",\"store\":\"Save on Foods\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Strawberries\",\"price\":\"9.43\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg\",\"store\":\"Walmart\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"}]";

        /// <summary>
        /// Combine and execute all functions needed to push notification.
        /// </summary>
        /// <param name="context">IJobExecutionContext</param>
        /// <returns>CompletedTask</returns>
        public async Task Execute(IJobExecutionContext context)
        {
            bool isSavedList = ReadSavedList();
            if (isSavedList)
            {
                GetNewPrices();
                PushNotificationOnLowerPriceFound();
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Read saved list json file and store it in a list.
        /// </summary>
        public bool ReadSavedList()
        {
            savedItems = parser.deserializeItems();
            if (savedItems == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Loop through the list, get new prices for the items and save in a list.
        /// </summary>
        public void GetNewPrices()
        {
            Console.WriteLine("in GetNewPrices");

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

        /// <summary>
        /// Push notification if lower price of the item is found.
        /// </summary>
        /// <returns>count of pushed notification</returns>
        public int PushNotificationOnLowerPriceFound()
        {
            int notificationCount = 0;
            for (int index = 0; index < updatedItems.Count; index++)
            {
                Item updatedItem = updatedItems[index];
                Item originalItem = savedItems[index];

                double updatedPrice = ExtractDoubleFromString(updatedItem.price);
                double originalPrice = ExtractDoubleFromString(originalItem.price);

                if (updatedPrice < originalPrice)
                {
                    double priceDifference = originalPrice - updatedPrice;
                    new ToastContentBuilder()
                         .AddHeader("header", "New Price Found!", "")
                         .AddText("We found your saved item " + updatedItem.name
                                  + " with $"
                                  + priceDifference.ToString()
                                  + " lower price")
                         .Show();
                    notificationCount++;
                }
            }
            return notificationCount;
        }

        /// <summary>
        /// Extracts a double value from the given string.
        /// </summary>
        /// <param name="priceString"></param>
        /// <returns>a double</returns>
        public double ExtractDoubleFromString(string priceString)
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(Regex.Match(priceString, @"\d+(.\d+)?").Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
