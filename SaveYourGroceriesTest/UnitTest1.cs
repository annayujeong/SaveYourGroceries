using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestNoSuchElementException()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            //Act
            Exception exception = Assert.ThrowsException<NoSuchElementException>(() =>
            {
                webScraper.SearchItemsTandT(";;;");
                webScraper.driver.Quit();
            });

            //Assert
            Assert.IsTrue(exception is NoSuchElementException);
        }

        [TestMethod]
        public void TestScrapTnTItemName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemsTandT("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.IsTrue(item.name.ToLower().Contains("apple"));
        }

        [TestMethod]
        public void TestScrapTnTItemStoreName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemsTandT("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual("T & T Supermarket", item.store);
        }

        [TestMethod]
        public void TestScrapTnTItemImageUrl()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();
            string expectedUrl = "https://www.tntsupermarket.com/media/catalog/product/cache/1b10eb595fa02731ea0609dbbcedd549/5/0/50346_gala_apple.jpg";

            // Act
            Item item = webScraper.SearchItemsTandT("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual(expectedUrl, item.imageUrl);
        }

        [TestMethod]
        public void TestScrapSaveOnFoodItemName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSaveOnFoods("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.IsTrue(item.name.ToLower().Contains("apple"));
        }

        [TestMethod]
        public void TestScrapSaveOnFoodsItemStoreName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSaveOnFoods("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual("Save On Foods", item.store);
        }

        [TestMethod]
        public void TestScrapSaveOnFoodsItemImageUrl()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();
            string expectedUrl = "https://storage.googleapis.com/images-sof-prd-9fa6b8b.sof.prd.v8.commerce.mi9cloud.com/product-images/cell/4139.jpg";

            // Act
            Item item = webScraper.SearchItemSaveOnFoods("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual(expectedUrl, item.imageUrl);
        }
    }
}
