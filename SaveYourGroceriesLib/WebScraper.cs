using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace SaveYourGroceriesLib
{
    public class WebScraper
    {
        /// <summary>
        /// This class is responsible for creating a web browser responsible for scraping information from different grocery stores.
        /// Author: Bradner
        /// Resources used/referenced: https://www.selenium.dev/documentation/
        ///                            https://www.guru99.com/selenium-tutorial.html
        /// </summary>
        public IWebDriver driver;

        public WebScraper()
        { 
            var options = new ChromeOptions();

            options.AddArguments(new List<string>() { "headless", "disable-gpu" });
            options.AddArgument("headless");
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("useAutomaticExtension=false");
            driver = new ChromeDriver(options);

            // wait time for the page to fully load
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        /// <summary>
        /// Takes in a list of gorcery stores to search and scrapes each grocery store for item information, and returns
        /// a list of Item objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="itemName"></param>
        /// <param name="storesToSearch">a list of grocery stores to search</param>
        /// <returns>an array list of Items</returns>
        public ArrayList SearchItem(object sender, EventArgs e, string itemName, ArrayList storesToSearch)
        {

            ArrayList items = new ArrayList();

            foreach (string item in storesToSearch)
            {
                if (item.Equals(Store.Superstore.ToString()))
                {
                    items.Add(SearchItemSuperstore(itemName));
                }
                if (item.Equals(Store.Walmart.ToString()))
                {
                    items.Add(SearchItemWalmart(itemName));
                }
                if (item.Equals(Store.T_and_T.ToString()))
                {
                    items.Add(SearchItemsTandT(itemName));
                }
                if (item.Equals(Store.Save_On_Foods.ToString()))
                {
                    items.Add(SearchItemSaveOnFoods(itemName));
                }
            }
            return items;
        }

        /// <summary>
        /// Searches the Superstore website for the given item and returns it if found.
        /// </summary>
        /// <param name="queriedItem">the item to search</param>
        /// <returns>an Item object</returns>
        public Item SearchItemSuperstore(string queriedItem)
        {
            Item item = new Item();

            driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=" + queriedItem;

            try
            {
                string price = driver.FindElement(By.ClassName(Constants.SUPERSTORE_ITEM_PRICE)).Text;
                item.price = price;

                string itemName = driver.FindElement(By.ClassName(Constants.SUPERSTORE_ITEM_NAME)).GetAttribute("title");
                item.name = itemName;

                string imageURL = driver.FindElements(By.ClassName(Constants.SUPERSTORE_ITEM_IMAGE))[0].GetAttribute("src");
                item.imageUrl = imageURL;

                string itemURL = driver.FindElement(By.ClassName(Constants.SUPERSTORE_ITEM_URL)).GetAttribute("href");
                item.itemURL = itemURL;

                item.store = Store.Superstore.ToString();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return item;
        }

        /// <summary>
        /// Searches the Walmart website for the given item and returns it if found.
        /// </summary>
        /// <param name="queriedItem">the item to search</param>
        /// <returns>an Item object</returns>
        public Item SearchItemWalmart(string queriedItem)
        {
            Item item = new Item();

            try
            {
                driver.Url = "https://www.walmart.ca/search?q=" + queriedItem + "&c=10019";

                string itemPrice = driver.FindElement(By.ClassName(Constants.WALMART_ITEM_PRICE)).Text;
                item.price = itemPrice;

                string itemName = driver.FindElement(By.ClassName(Constants.WALMART_ITEM_NAME)).Text;
                item.name = itemName;

                string imageURL = driver.FindElement(By.ClassName(Constants.WALMART_ITEM_IMAGE)).GetAttribute("src");
                item.imageUrl = imageURL;

                string itemURL = driver.FindElement(By.ClassName(Constants.WALMART_ITEM_URL)).GetAttribute ("href");
                item.itemURL = itemURL; 

                item.store = Store.Walmart.ToString();

            } catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return item;
        }

        /// <summary>
        /// Searches the Superstore website for the given item and returns it if found.
        /// </summary>
        /// <param name="queriedItem">the item to search</param>
        /// <returns>an Item object</returns>
        public Item SearchItemSaveOnFoods(string queriedItem)
        {
            Item item = new Item();

            try
            {
                driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=" + queriedItem;

                string itemPrice = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_PRICE)).GetAttribute("innerText");
                item.price = itemPrice;

                string itemName = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_NAME)).GetAttribute("innerText");
                item.name = itemName;

                string imageURL = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_IMAGE)).GetAttribute("src");
                item.imageUrl = imageURL;

                string itemURL = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_URL)).GetAttribute("href");
                item.itemURL = itemURL;

                item.store = Store.Save_On_Foods.ToString();

            } catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return item;
        }

        /// <summary>
        /// Searches the Superstore website for the given item and returns it if found.
        /// </summary>
        /// <param name="queriedItem">the item to search</param>
        /// <returns>an Item object</returns>
        public Item SearchItemsTandT(string itemName)
        {

            Item item = new Item();

            driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=" + itemName;
            
            item.name = driver.FindElement(By.ClassName(Constants.TANDT_ITEM_NAME)).GetAttribute("title");

            item.price = driver.FindElement(By.ClassName(Constants.TANDT_ITEM_PRICE)).Text;

            item.imageUrl = driver.FindElement(By.ClassName(Constants.TANDT_ITEM_IMAGE)).GetAttribute("src");

            string itemURL = driver.FindElement(By.ClassName(Constants.TANDT_ITEM_URL)).GetAttribute("href");
            item.itemURL = itemURL;

            item.store = Store.T_and_T.ToString();

            return item;
        }
    }

}
