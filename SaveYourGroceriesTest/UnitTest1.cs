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
            Assert.AreEqual("Gala Apple 3.2lbs", item.name);
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
            Assert.AreEqual(Store.T_and_T.ToString(), item.store);
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
        public void TestScrapTnTItemPrice()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemsTandT("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.IsTrue(item.price.Contains("$2.22"));
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
            Assert.IsTrue(item.name.Contains("Apples - Granny Smith, 160 Gram"));
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
            Assert.AreEqual(Store.Save_On_Foods.ToString(), item.store);
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
        public void TestScrapSaveOnFoodsItemPrice()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSaveOnFoods("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.IsTrue(item.price.Contains("$1.05"));
        }

        [TestMethod]
        public void TestInvalidDriverUrl()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Exception exception = Assert.ThrowsException<WebDriverException>(() =>
            {
                webScraper.driver.Url = "http://annasinvalidurl.com";
                webScraper.driver.Quit();
            });

            // Assert
            Assert.IsTrue(exception is WebDriverException);
        }

        [TestMethod]
        public void TestScrapSuperStoreItemName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSuperstore("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual("Royal Gala Apples", item.name);
        }

        [TestMethod]
        public void TestScrapSuperStoreItemStoreName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSuperstore("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual("Superstore", item.store);
        }

        [TestMethod]
        public void TestScrapSuperStoreItemImageUrl()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();
            string expectedUrl = "https://assets.shop.loblaws.ca/products/20083526001/b1/en/front/20083526001_front_a01.png";

            // Act
            Item item = webScraper.SearchItemSuperstore("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual(expectedUrl, item.imageUrl);
        }

        [TestMethod]
        public void TestScrapSuperStoreItemPrice()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSuperstore("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.IsTrue(item.price.Contains("$1.38"));
        }
    }
}
