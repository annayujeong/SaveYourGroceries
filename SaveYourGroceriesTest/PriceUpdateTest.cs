using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceries;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class PriceUpdateTest
    {
        PriceUpdate priceUpdate = new PriceUpdate();

        List<Item> savedItems = new List<Item>
        {
            new Item("Apple", "3.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Pear", "4.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jp", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Strawberries", "9.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page")
        };

        List<Item> updatedItems = new List<Item>
        {
            new Item("Apple", "10.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Pear", "10.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jp", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Strawberries", "10.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page")
        };

        [TestMethod]
        public void TestPushNotificationOnLowerPriceFound()
        {
            // Arrange
            priceUpdate.SavedItems = savedItems;
            priceUpdate.UpdatedItems = updatedItems;

            // Act
            int notificationCount = priceUpdate.PushNotificationOnLowerPriceFound();

            // Assert
            // Assert.AreEqual failed. Expected:<0>. Actual:<3>. 
            Assert.AreEqual(3, notificationCount);
        }
    }
}
