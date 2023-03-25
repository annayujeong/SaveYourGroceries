using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceries;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class PriceUpdateTest
    {
        PriceUpdate priceUpdate = new PriceUpdate();

        [TestMethod]
        public void TestPushNotificationOnLowerPriceFound()
        {
            // Arrange
            priceUpdate.SavedItems = new List<Item>
            {
            new Item("Apple", "10.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Pear", "10.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jp", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Strawberries", "10.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page")
            };
            priceUpdate.UpdatedItems = new List<Item>
            {
            new Item("Apple", "2.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Pear", "2.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jp", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page"),
            new Item("Strawberries", "2.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page")
            };

            // Act
            int notificationCount = priceUpdate.PushNotificationOnLowerPriceFound();

            // Assert
            Assert.AreEqual(3, notificationCount);
        }

        [TestMethod]
        public void TestExtractDoubleFromString()
        {
            // Arrange
            string originalPriceString1 = "$3.54/lbs";
            string originalPriceString2 = "price: 1.23";

            // Act
            double resultPriceDouble1 = priceUpdate.ExtractDoubleFromString(originalPriceString1);
            double resultPriceDouble2 = priceUpdate.ExtractDoubleFromString(originalPriceString2);

            // Assert
            Assert.AreEqual(3.54, resultPriceDouble1);
            Assert.AreEqual(1.23, resultPriceDouble2);
        }
    }
}
