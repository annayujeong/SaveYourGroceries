using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SaveYourGroceriesLib
{
    public class WebScraper
    {
        private IWebDriver driver = new ChromeDriver();

        public WebScraper()
        {
            var options = new ChromeOptions()
            {
                BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
            };

            options.AddArguments(new List<string>() { "headless", "disable-gpu" });
        }

        public Item SearchItem(object sender, EventArgs e, string itemName)
        {
            Item item = new Item();

            // console doesn't close if application crashes?

            // walmart -> works
            // save on foods -> works
            // t and t supermarket -> works

            // superstore -> does not work
            // no frills -> does not work

            // limitation -> grabbing only first element that matches the class name/xpath/etc, so
            // generic query such as "apple" may result in different types of apples being compared

            // walmart query works
            //driver.Url = "https://www.walmart.ca/search?q=apples&c=10019";
            //string price = driver.FindElement(By.ClassName("css-2vqe5n")).Text;

            //count++;

            // TODO: figure out why superstore and no frills query doesn't work

            //driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=Apples";
            //string price = driver.FindElement(By.CssSelector("selling-price-list__item__price--now-price__value")).Text;
            //string price = driver.FindElement(By.XPath()).Text;

            // no frills query -> not working
            //driver.Url = "https://www.nofrills.ca/search?search-bar=apple";
            //string price = driver.FindElement(By.ClassName("selling-price-list__item__price--now-price__value")).Text;

            // save on foods - works
            // element found, but empty string -> need to get "innerText" attribute
            //driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=apple";
            //string price = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");

            // t and t supermarket -> works
            // how to handle irregular unit sizes?
            //driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=apple";

            Debug.WriteLine("Item name: " + itemName);

            driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=" + itemName;

            try
            {
                // TODO: need to set wait in here or in MainForm searchButton_Click
                //       since sometimes it takes some time to load the search result
                item.name = driver.FindElement(By.ClassName("item-name--yq")).GetAttribute("title");
                item.price = driver.FindElement(By.ClassName("item-price-zRu")).Text;
                item.imageUrl = driver.FindElement(By.ClassName("item-image-4D0")).GetAttribute("src");

            } catch (NoSuchElementException error)
            {
                MessageBox.Show(error.ToString());
            }
            return item;
        }

    }

}
