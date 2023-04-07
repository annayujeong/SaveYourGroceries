using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceriesLib;
using System.Windows.Forms;
using JSONParser = SaveYourGroceriesLib.JSONParser;
using Item = SaveYourGroceriesLib.Item;


namespace SaveYourGroceriesTest
{
    /// <summary>
    /// Unit Tests that tests the methods that saves an item to the Saved Items List. 
    /// </summary>
    [TestClass]
    public class SavedItemsListTest
    {
        private Item apple = new Item("Apple", "3.45", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg", "Superstore", "https://en.wikipedia.org/wiki/Main_Page");
        private Item pear = new Item("Pear", "4.56", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg", "Save on Foods", "https://en.wikipedia.org/wiki/Main_Page");
        private Item strawberry = new Item("Strawberries", "9.43", "https://upload.wikimedia.org/wikipedia/commons/6/64/Garden_strawberry_%28Fragaria_%C3%97_ananassa%29_single.jpg", "Walmart", "https://en.wikipedia.org/wiki/Main_Page");
        private Item watermelon = new Item("Watermelon", "24.23", "https://www.veseys.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/s/u/sunsugarmelon-sunsugarmelon-image-15725%20sunsugar.jpg", "T & T Supermarket", "https://en.wikipedia.org/wiki/Main_Page");

        /// <summary>
        /// Tests the ability of the Saved Items List to display the correct amount
        /// of items after an item has been added to the list.  
        /// </summary>
        [TestMethod]
        public void savedItemListDisplaysListValueAfterItemAdded()
        {
            // Arrange 
            JSONParser parser = JSONParser.getInstance();
            SearchedItem searchedItem = new SearchedItem(apple);
            parser.clearSavedItems();

            // Act
            parser.addItem(apple);
            parser.getSavedItemsLength().ToString();
            parser.serializeItems();

            // Assert
            Assert.AreEqual(1, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Tests the ability of the Saved Items List to display the correct amount
        /// of items after an item has been removed to the list.  
        /// </summary>
        [TestMethod]
        public void savedItemListDisplaysListAfterItemRemoved()
        {
            // Arrange 
            JSONParser parser = JSONParser.getInstance();
            SearchedItem searchedItem = new SearchedItem(pear);
            parser.clearSavedItems();

            // Act
            parser.addItem(pear);
            parser.addItem(watermelon);
            parser.removeItem(pear);
            parser.getSavedItemsLength().ToString();
            parser.serializeItems();

            // Assert
            Assert.AreEqual(1, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Tests the ability of the Saved Items List to display the correct amount
        /// of items when there are no items in the list.  
        /// </summary>
        [TestMethod]
        public void savedItemListDisplaysItemCountInListWithNoItems()
        {
            // Arrange 
            JSONParser parser = JSONParser.getInstance();
            SearchedItem searchedItem = new SearchedItem(strawberry);

            // Act
            parser.addItem(strawberry);
            parser.removeItem(strawberry);
            parser.getSavedItemsLength().ToString();
            parser.serializeItems();

            // Assert
            Assert.AreEqual(0, parser.getSavedItemsLength());
        }

        /// <summary>
        /// Tests the ability of the Saved Items List to display a pop up message 
        /// indicating an item has been saved to the list.  
        /// </summary>
        /// 
        [TestMethod]
        public void displayItemNameToVerifyItemHasBeenSaved()
        {
            // Arrange 
            JSONParser parser = JSONParser.getInstance();
            SearchedItem searchedItem = new SearchedItem(watermelon);

            // Act
            parser.addItem(watermelon);
            parser.getSavedItemsLength().ToString();
            MessageBox.Show(watermelon.name + "has been added to the Saved List");
            parser.serializeItems();

            // Assert
           Assert.AreEqual("Watermelon has been added to the Saved List", watermelon.name);
        }
    }
}
