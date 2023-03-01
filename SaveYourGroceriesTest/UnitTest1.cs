using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestNoSuchElementException()
        //{
        //    // Arrange
        //    WebScraper webScraper = new WebScraper();
        //    Button button = new Button();
        //    EventArgs e = EventArgs.Empty;

        //    // Act, Assert
        //    Assert.ThrowsException<NoSuchElementException>(() =>
        //    {
        //        webScraper.SearchItem(button, e, "'''");
        //    });
        //}

        [TestMethod]
        public void TestScrapSearchItemListNotNull()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();
            Button button = new Button();
            EventArgs e = EventArgs.Empty;

            // Act
            List<Item> itemList = webScraper.SearchItem(button, e, "apple");

            // Assert
            Assert.IsNotNull(itemList);
        }

        [TestMethod]
        public void TestScrapSearchItemName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();
            Button button = new Button();
            EventArgs e = EventArgs.Empty;

            // Act
            List<Item> itemList = webScraper.SearchItem(button, e, "apple");

            // Assert
            Assert.IsTrue(itemList[0].name.ToLower().Contains("apple"));
        }
    }
}
