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
        private IWebDriver driver = new FirefoxDriver();

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

        // walmart -> works
        // save on foods -> works
        // t and t supermarket -> works
        // superstore -> works

        // TODO: figure out why no frills query doesn't work
        // no frills -> does not work

        //driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=Apples";
        //string price = driver.FindElement(By.CssSelector("selling-price-list__item__price--now-price__value")).Text;
        //string price = driver.FindElement(By.XPath()).Text;


        // Superstore has sponsored items in its search result, how to handle?
        public Item SearchItemSuperstore(string queriedItem)
        {
            Item item = new Item();

            driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=" + queriedItem;

            try
            {
                //string price = driver.FindElement(By.CssSelector("selling-price-list__item__price--now-price__value")).Text;

                string price = driver.FindElement(By.ClassName("selling-price-list__item__price--now-price__value")).Text;

                string itemName = driver.FindElement(By.ClassName("product-name__item--name")).GetAttribute("title");


                // ignoring image banner, better method?
                string imageURL = driver.FindElements(By.ClassName("responsive-image"))[1].GetAttribute("src");

                item.price = price;
                item.name = itemName;
                item.imageUrl = imageURL;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return item;
        }

        // no frills query -> not working
        //driver.Url = "https://www.nofrills.ca/search?search-bar=apple";
        //string price = driver.FindElement(By.ClassName("selling-price-list__item__price--now-price__value")).Text;

        // limitation -> grabbing only first element that matches the class name/xpath/etc, so
        // generic query such as "apple" may result in different types of apples being compared

        public ArrayList SearchItem(object sender, EventArgs e, string itemName)
        {

            ArrayList items = new ArrayList();


            // TODO: Searching more than once causes Walmart to block further searches
            //items.Add(SearchItemWalmart(itemName));

            items.Add(SearchItemSaveOnFoods(itemName));
            //items.Add(SearchItemsTandT(itemName));

            //items.Add(SearchItemSuperstore(itemName));    


            foreach(Item item in items)
            {
                MessageBox.Show(item.name + "\n" + item.price + "\n" + item.imageUrl);
            }

            return items;
        }


        public Item SearchItemWalmart(string queriedItem)
        {
            Item item = new Item();


            // walmart query works
            //driver.Url = "https://www.walmart.ca/search?q=apples&c=10019";
            //string price = driver.FindElement(By.ClassName("css-2vqe5n")).Text;

            try
            {
                driver.Url = "https://www.walmart.ca/search?q=" + queriedItem + "&c=10019";

                string itemPrice = driver.FindElement(By.ClassName("css-2vqe5n")).Text;
                item.price = itemPrice;

                string itemName = driver.FindElement(By.ClassName("css-1p4va6y")).Text;
                item.name = itemName;

                string imageURL = driver.FindElement(By.ClassName("css-19q6667")).GetAttribute("src");
                item.imageUrl = imageURL;

                return item;

            } catch (Exception e)
            {
                MessageBox.Show("There was an error lol");
            }

            return item;

        }

        public Item SearchItemSaveOnFoods(string queriedItem)
        {
            Item item = new Item();

            // save on foods - works
            // element found, but empty string -> need to get "innerText" attribute
            //driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=apple";
            //string price = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");

            try
            {

                driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=" + queriedItem;

                string itemPrice = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");
                item.price = itemPrice;


                string itemName = driver.FindElement(By.ClassName("sc-hKFyIo")).Text;
                item.name = itemName;

                // skipping past shop banner image
                string imageURL = driver.FindElements(By.ClassName("Image--v39pjb"))[2].GetAttribute("src");
                item.imageUrl = imageURL;

                return item;

            } catch (Exception e)
            {
                MessageBox.Show("There was an error lol");
            }

            return item;

        }

        public Item SearchItemsTandT(string itemName)
        {

            Item item = new Item();

            // t and t supermarket -> works
            // how to handle irregular unit sizes?
            //driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=apple";

            driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=" + itemName;

            try
            {
                // TODO: need to set wait in here or in MainForm searchButton_Click
                //       since sometimes it takes some time to load the search result
                item.name = driver.FindElement(By.ClassName("item-name--yq")).GetAttribute("title");
                item.price = driver.FindElement(By.ClassName("item-price-zRu")).Text;
                item.imageUrl = driver.FindElement(By.ClassName("item-image-4D0")).GetAttribute("src");

            }
            catch (NoSuchElementException error)
            {
                MessageBox.Show(error.ToString());
            }
            return item;
        }
    }

}
