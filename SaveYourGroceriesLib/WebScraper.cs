using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceriesLib
{
    public class WebScraper
    {
        int count = 0;
        private IWebDriver driver;

        public WebScraper()
        {
            var options = new ChromeOptions()
            {
                BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
            };

            options.AddArguments(new List<string>() { "headless", "disable-gpu" });
        }

        private void OnCounterClicked1(object sender, EventArgs e)
        {
            //// console doesn't close if application crashes?

            //// walmart costco superstore saveonfoods 

            //// walmart -> works
            //// save on foods -> works
            //// t and t supermarket -> works

            //// superstore -> does not work
            //// no frills -> does not work

            //// limitation -> grabbing only first element that matches the class name/xpath/etc, so
            //// generic query such as "apple" may result in different types of apples being compared

            //// walmart query works
            ////driver.Url = "https://www.walmart.ca/search?q=apples&c=10019";
            ////string price = driver.FindElement(By.ClassName("css-2vqe5n")).Text;


            //count++;

            //string queriedItem = queryText.Text;

            //// TODO: figure out why superstore and no frills query doesn't work

            ////driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=Apples";
            ////string price = driver.FindElement(By.CssSelector("selling-price-list__item__price--now-price__value")).Text;
            ////string price = driver.FindElement(By.XPath()).Text;

            //// no frills query -> not working
            ////driver.Url = "https://www.nofrills.ca/search?search-bar=apple";
            ////string price = driver.FindElement(By.ClassName("selling-price-list__item__price--now-price__value")).Text;

            //// save on foods - works
            //// element found, but empty string -> need to get "innerText" attribute
            ////driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=apple";
            ////string price = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");

            //// t and t supermarket -> works
            //// how to handle irregular unit sizes?
            ////driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=apple";

            //driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=" + queriedItem;

            //try
            //{
            //    string price = driver.FindElement(By.ClassName("item-price-zRu")).Text;

            //    string imageURL = driver.FindElement(By.ClassName("item-image-4D0")).GetAttribute("src");

            //    queriedItemImage.Source = imageURL;

            //    queriedItemName.Text = driver.FindElement(By.ClassName("item-name--yq")).GetAttribute("title");

            //    if (price == null)
            //    {
            //        CounterBtn1.Text = "No item found";
            //        CounterBtn2.Text = queriedItem;
            //    }
            //    else
            //    {
            //        CounterBtn1.Text = queriedItem;
            //        CounterBtn2.Text = price;
            //    }
            //}
            //catch (NoSuchElementException error)
            //{
            //    CounterBtn2.Text = error.ToString();
            //}

            //SemanticScreenReader.Announce(CounterBtn1.Text);
        }

    }

}
