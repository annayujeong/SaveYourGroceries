using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SaveYourGroceriesTest
{
	[TestClass]
	public class Webscraper

	// Unit test for SearchItem() that uses the URL of Save On Foods to retrieve info for grocery item and its price. 
	{
		[TestMethod]
		public void SearchItem()
		{
			//Arrange   
			string price = driver.FindElement(By.ClassName("jwvBiZ")).GetAttribute("innerText");

			//Act 
			driver.Url = "https://www.saveonfoods.com/sm/pickup/rsid/1982/results?q=apple";

			//Assert

			if string message.Actual = "element found!" + SearchItem(price){ 

			}
			return false


		}
	}

	[TestClass]
	public class Webscraper

	// Unit test for SearchItem() that uses the URL of TnT Supermarket to retrieve info for grocery item and its price. 
	{
		[TestMethod]
		public void SearchItem()
		{
			//Arrange   
			string price = string price = driver.FindElement(By.ClassName("css-2vqe5n")).Text;

			//Act 
			driver.Url = "https://www.tntsupermarket.com/eng/search.html?query=apple";

			//Assert

			if string message.Actual = "element found!" + SearchItem(price){
				return true
			}
			return false


		}
	}



	[TestClass]
	public class Webscraper

	// Unit test for SearchItem() that uses the URL of Walmart to retrieve info for grocery item and its price. 
	{
		[TestMethod]
		public void SearchItem()
		{
			//Arrange   
			string price = string price = driver.FindElement(By.ClassName("css-2vqe5n")).Text;

			//Act 
			driver.Url = "https://www.walmart.ca/search?q=apples&c=10019";

			//Assert

			if string message.Actual = "selling-price-list__item__price--now-price__value" + SearchItem(price){
				return true
			}
			return false


		}
	}


}