using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Hosting;
using System.Text;
using Newtonsoft.Json;


namespace SaveYourGroceriesTest
{
    /// <summary>
    /// Unit tests to determine whether JSON CRUD operations are correctly working.
    /// </summary>

    [TestClass]
    public class JSONParserTest
    {

        private string correctJSON = "[{\"name\":\"Apple\",\"price\":\"3.45\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg\",\"store\":\"Superstore\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Pear\",\"price\":\"4.56\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg\",\"store\":\"Save on Foods\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"},{\"name\":\"Strawberries\",\"price\":\"9.43\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg\",\"store\":\"Walmart\",\"itemURL\":\"https://en.wikipedia.org/wiki/Main_Page\"}]";
        private string corruptedJSON = "[{\"name\":\"rqweApple\",\"price\":\rqwe3.45\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg\",\"store\":\"Superstore\"},{\"name\":\"Pear\",\"price\":\"4.56\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg\",\"store\":\"Save on Foods\"},{\"name\":\"Strawberries\",\"price\":\"9.43\",\"imageUrl\":\"https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg\",\"store\":\"Walmart\"},{\"name\":\"Watermelon\",\"price\":\"24.23\",\"imageUrl\":\"https://www.veseys.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/s/u/sunsugarmelon-sunsugarmelon-image-15725%20sunsugar.jpg\",\"store\":\"T & T Supermarket\"}, qwer]";

        private Item apple = new Item("Apple", "3.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page");
        private Item pear = new Item("Pear", "4.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page");
        private Item strawberry = new Item("Strawberries", "9.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page");
        private Item watermelon = new Item("Watermelon", "24.23", "https://www.veseys.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/s/u/sunsugarmelon-sunsugarmelon-image-15725%20sunsugar.jpg", "T & T Supermarket", "https://en.wikipedia.org/wiki/Main_Page");

        /// <summary>
        /// Test whether a JSON file can be serialized and deserialized from.
        /// </summary>
        [TestMethod]
        public void TestJSONParserSerializeAndDeserialize()
        {
            // Arrange
            JSONParser parser = JSONParser.getInstance();
            parser.clearSavedItems();
            List<Item> testItems;
            List<Item> actualItems = new List<Item>();
            int count = 0;

            // Act
            parser.createJSONFile();

            parser.addItem(apple);
            parser.addItem(pear);
            parser.addItem(strawberry);

            parser.serializeItems();

            testItems = parser.deserializeItems();

            actualItems.Add(apple);
            actualItems.Add(pear);
            actualItems.Add(strawberry);

            // Arrange
            foreach (Item testItem in testItems)
            {
                Assert.AreEqual(actualItems[count].name, testItem.name);
                Assert.AreEqual(actualItems[count].price, testItem.price);
                Assert.AreEqual(actualItems[count].imageUrl, testItem.imageUrl);
                Assert.AreEqual(actualItems[count].store, testItem.store);
                Assert.AreEqual(actualItems[count].itemURL, testItem.itemURL);
                count++;
            }
        }

        /// <summary>
        /// Test whether a JSON file is created in the proper location.
        /// </summary>
        [TestMethod]
        public void TestJSONFileCreation()
        {
            // Arrange
            JSONParser parser = JSONParser.getInstance();

            // Act
            parser.createJSONFile();

            // Assert
            Assert.IsTrue(parser.JSONFileExists());
        }

        /// <summary>
        /// Test whether an item can be successfully added to the list of saved items.
        /// </summary>
        [TestMethod]
        public void TestItemsListAddition()
        {
            // Arrange
            JSONParser parser = JSONParser.getInstance();
            parser.clearSavedItems();

            // Act
            parser.addItem(apple);
            parser.addItem(pear);
            parser.addItem(strawberry);

            // Assert
            Assert.AreEqual(3, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Test whether an item can be successfully removed from the list of saved items.
        /// </summary>
        [TestMethod]
        public void TestItemsListDeletion()
        {
            // Arrange
            JSONParser parser = JSONParser.getInstance();
            parser.clearSavedItems();

            // Act
            parser.addItem(apple);
            parser.addItem(pear);
            parser.addItem(strawberry);
            parser.removeItem(apple);
            parser.removeItem(strawberry);

            // Assert
            Assert.AreEqual(1, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Test whether a JSON file can be serialized from multiple times in succession.
        /// </summary>
        [TestMethod]
        public void TestSerializeMultipleTimes()
        {
            // Arrange
            JSONParser parser = JSONParser.getInstance();
            parser.clearSavedItems();
            List<Item> testItems;

            // Act
            parser.addItem(apple);
            parser.addItem(pear);
            parser.addItem(strawberry);

            parser.serializeItems();

            parser.addItem(watermelon);

            parser.serializeItems();

            testItems = parser.deserializeItems();

            // Assert
            Assert.AreEqual(4, testItems.Count);
        }

        /// <summary>
        /// Test whether a JSON file can successfully be loaded from.
        /// </summary>
        [TestMethod]
        public void TestLoadJSONData()
        {
            // Arrange
            setupJSONFile();
            JSONParser parser = JSONParser.getInstance();

            // Act
            parser.deserializeItems();

            // Assert
            Assert.AreEqual(3, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Test whether the class successfully handles loading from an empty JSON file.
        /// </summary>
        [TestMethod]
        public void TestDeserializeEmptyFile()
        {
            // Arrange
            setupJSONFileEmpty();
            JSONParser parser = JSONParser.getInstance();
            List<Item> testItems = new List<Item>();

            // Act
            testItems = parser.deserializeItems();

            // Assert
            Assert.AreEqual(0, parser.getSavedItemsLength() );
        }

        /// <summary>
        /// Test whether a corrupt JSON file is correctly handled.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestLoadJSONDataCorrupted()
        {
            // Arrange
            setupJSONFileCorrupted();
            JSONParser parser = JSONParser.getInstance();
            Exception e = null;

            // Act
            try
            {
                parser.deserializeItems();
            } catch (Exception ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsTrue(e != null);
            Assert.AreEqual("This JSON file appears to be incorrectly formatted", e.Message);
        }

        /// <summary>
        /// Creates JSON file for testing purposes.
        /// </summary>
        private void setupJSONFile()
        {
            if (File.Exists(Constants.JSON_FILE_LOCATION))
            {
                File.Delete(Constants.JSON_FILE_LOCATION);

                using (StreamWriter sw = File.CreateText(Constants.JSON_FILE_LOCATION))
                {
                    sw.WriteLine(correctJSON);
                }
            }
        }

        /// <summary>
        /// Creates a JSON file with incorrect formatting for testing purposes.
        /// </summary>
        private void setupJSONFileCorrupted()
        {
            if (File.Exists(Constants.JSON_FILE_LOCATION))
            {
                File.Delete(Constants.JSON_FILE_LOCATION);

                using (StreamWriter sw = File.CreateText(Constants.JSON_FILE_LOCATION))
                {
                    sw.WriteLine(corruptedJSON);
                }
            }
        }

        /// <summary>
        /// Creates an empty JSON file for testing purposes.
        /// </summary>
        private void setupJSONFileEmpty()
        {
            if (File.Exists(Constants.JSON_FILE_LOCATION))
            {
                File.Delete(Constants.JSON_FILE_LOCATION);
            }
        }
    }
}

