using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class Webscraper

    // Unit test for SearchItem() that uses the URL of No Frills to retrieve info for grocery item. 
    {
        [TestMethod]
        public void SearchItem()
        {
            //Arrange   
            string price = driver.FindElement(By.ClassName("selling-price-list__item__price--now-price__value")).Text;

            //Act 
            driver.Url = "https://www.nofrills.ca/search?search-bar=apple";

            //Assert

            if string message.Actual = "selling-price-list__item__price--now-price__value"{
                return true
            }
            return false

        }
    }
}