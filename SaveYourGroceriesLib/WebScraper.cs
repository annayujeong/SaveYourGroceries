using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SaveYourGroceriesLib
{
    public class WebScraper
    {
        public IWebDriver driver = new ChromeDriver();

        public WebScraper()
        {
            // Need to wait for page to be fully loaded
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var options = new ChromeOptions()
            //{
            //    BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
            //};

            //options.AddArguments(new List<string>() { "headless", "disable-gpu" });
        }

        // console doesn't close if application crashes?

        // limitation -> grabbing only first element that matches the class name/xpath/etc, so
        // generic query such as "apple" may result in different types of apples being compared

        public ArrayList SearchItem(object sender, EventArgs e, string itemName)
        {

            ArrayList items = new ArrayList();


            // TODO: Searching more than once causes Walmart to block further searches
            
            items.Add(SearchItemWalmart(itemName));
            items.Add(SearchItemSaveOnFoods(itemName));
            items.Add(SearchItemsTandT(itemName));
            items.Add(SearchItemSuperstore(itemName));    


            foreach(Item item in items)
            {
                MessageBox.Show(item.name + "\n" + item.price + "\n" + item.imageUrl + "\n" + item.itemURL);
            }

            return items;
        }

        // Superstore has sponsored items in its search result, how to handle?
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

                // ignoring image banner, better method?
                string imageURL = driver.FindElements(By.ClassName(Constants.SUPERSTORE_ITEM_IMAGE))[1].GetAttribute("src");
                item.imageUrl = imageURL;

                string itemURL = driver.FindElement(By.ClassName(Constants.SUPERSTORE_ITEM_URL)).GetAttribute("href");
                item.itemURL = itemURL;

                item.store = Store.Superstore.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return item;
        }

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

        public Item SearchItemSaveOnFoods(string queriedItem)
        {
            Item item = new Item();

            // element found, but empty string -> need to get "innerText" attribute
            //driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=apple";
            //string price = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");

            try
            {
                driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=" + queriedItem;

                string itemPrice = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_PRICE)).GetAttribute("innerText");
                item.price = itemPrice;

                string itemName = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_NAME)).Text;
                item.name = itemName;

                // skipping past shop banner image
                //string imageURL = driver.FindElements(By.ClassName("Image--v39pjb"))[2].GetAttribute("src");
                string imageURL = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_IMAGE)).GetAttribute("src");
                item.imageUrl = imageURL;

                string itemURL = driver.FindElement(By.ClassName(Constants.SAVE_ON_FOODS_ITEM_URL)).GetAttribute("href");
                item.itemURL = itemURL;

                item.store = Store.Save_On_Foods.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return item;
        }

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

            //try
            //{
            //    // TODO: need to set wait in here or in MainForm searchButton_Click
            //    //       since sometimes it takes some time to load the search result
            //    item.name = driver.FindElement(By.ClassName("item-name--yq")).GetAttribute("title");
            //    item.price = driver.FindElement(By.ClassName("item-price-zRu")).Text;
            //    item.imageUrl = driver.FindElement(By.ClassName("item-image-4D0")).GetAttribute("src");
            //    item.store = "T & T Supermarket";

            //}
            //catch (NoSuchElementException ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //}
            return item;
        }
    }

}
