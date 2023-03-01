using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SaveYourGroceriesTest
{
	[TestClass]
	public class Webscraper

	// Unit test for SearchItem() that uses the URL of Real Canadian Superstore to retrieve info for grocery item. 
	{
		[TestMethod]
		public void SearchItem()
		{
			//Arrange 
			string price = driver.FindElement(By.CssSelector("selling-price-list__item__price--now-price__value")).Text;
			string price = driver.FindElement(By.XPath()).Text;

			//Act 
			driver.Url = "https://www.realcanadiansuperstore.ca/search?search-bar=Apples";

			//Assert

			if string message.Actual = "selling-price-list__item__price--now-price__value"{
				return true
			}

			return false 
		}
    }
}