using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SaveYourGroceriesLib;
using System;

namespace SaveYourGroceriesTest
{
    /// <summary>
    /// Unit tests to determine correct functionality for the Webscraper class.
    /// </summary>
    [TestClass]
    public class WebScraperTest
    {
        /// <summary>
        /// Test whether a NoSuchElementException is thrown by the webscraper.
        /// </summary>
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

        /// <summary>
        /// Test whether the webscraper succesfully gets an item from the T and T website.
        /// </summary>
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

        /// <summary>
        /// Test whether the webscraper successfully gets a result from the T and T website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct image URL is scraped from the T and T website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct item price is scraped from the T and T website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct item name is scraped from the Save on Foods website.
        /// </summary>
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

        /// <summary>
        /// Test whether a search result is returned for the Save on Foods website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct image URL is scraped from the Save on Foods website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct item price is scraped from the Save on Foods website.
        /// </summary>
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

        /// <summary>
        /// Test whether a WebDriverException is thrown when the Webscraper class is given an invalid URL.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct item name is scraped from the Superstore website.
        /// </summary>
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

        /// <summary>
        /// Test whether a search query is returned from the Superstore website.
        /// </summary>
        [TestMethod]
        public void TestScrapSuperStoreItemStoreName()
        {
            // Arrange
            WebScraper webScraper = new WebScraper();

            // Act
            Item item = webScraper.SearchItemSuperstore("apple");
            webScraper.driver.Quit();

            // Assert
            Assert.AreEqual(Store.Superstore.ToString(), item.store);
        }

        /// <summary>
        /// Test whether the correct image URL is scraped from the Superstore website.
        /// </summary>
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

        /// <summary>
        /// Test whether the correct item price is scraped from the Superstore website.
        /// </summary>
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
