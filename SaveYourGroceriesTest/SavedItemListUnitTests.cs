using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using SaveYourGroceries;
using System.Security.Cryptography.X509Certificates;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class SavedItemListUnitTests
    {
        //private Item Apple = new Item("Apple", "3.99", "Walmart", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg");
        //private Item Pear = new Item("Pear", "4.20", "TnT", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg");
        //private Item Watermelon = new Item("Watermelon", "6.99", "Superstore", "https://www.veseys.com/media/catalog/product/cache/image/700x700/e9c3970ab036de70892d86c6d221abfe/s/u/sunsugarmelon-sunsugarmelon-image-15725%20sunsugar.jpg");

        // Unit Tests for the SaveItemFromResultsPageOnButton_Click() method 

        //[TestMethod] // -- Return to Line 31 -- // 
        //public void Test_SaveItemFromResultsPageOnButton_Click_StoreName_Display()
        //{
        //    // Arrange

        //    SearchedItem searched = new SearchedItem();
        //    var Superstore = searched.storeNameTextBox.Text;
        //    Item item = new Item();
        //    EventArgs args = new EventArgs();


        //    //TextBox storeNameTextBox = new TextBox();
        //    //storeNameTextBox.Text = "Superstore";
        //    //Item item = new Item();

        //    ArrayList testSavedItemStoreNameList = new ArrayList();
        //    testSavedItemStoreNameList.Add("Superstore");

        //    // Act
        //    string testStoreNameEntry = searched.SaveItemFromResultsPageOnButton_Click("Superstore");


        //    // Assert
        //    Assert.AreEqual<string>("Superstore", testStoreNameEntry);
        //}

        //[TestMethod]
        //public void Test_SaveItemFromResultsPageOnButton_Click_ItemName_Display()
        //{

        //    // Arrange

        //    SearchedItem searched = new SearchedItem();
        //    var Apple = searched.itemNameTextBox.Text;
        //    Item item = new Item();
        //    EventArgs args = new EventArgs();

        //    ArrayList testSavedItemNameList = new ArrayList();
        //    testSavedItemNameList.Add("Apple");

        //    // Act
        //    string testNameEntry = searched.SaveItemFromResultsPageOnButton_Click(testSavedItemNameList);

        //    // Assert
        //    Assert.AreEqual("Apple", testNameEntry);

        //}

        //[TestMethod]
        //public void Test_SaveItemFromResultsPageOnButton_Click_ItemPrice_Display()
        //{

        //    // Arrange

        //    SearchedItem searched = new SearchedItem();
        //    string Price = searched.itemPriceTextBox.Text;
        //    Item item = new Item();
        //    Price = "2.99";
        //    EventArgs args = new EventArgs();

        //    ArrayList testSavedItemPriceList = new ArrayList();
        //    testSavedItemPriceList.Add("2.99");

        //    // Act
        //    string testItemPriceEntry = searched.SaveItemFromResultsPageOnButton_Click(testSavedItemPriceList);

        //    // Assert
        //    Assert.AreEqual<string>(Price, testItemPriceEntry);

        //}

        //// Unit Tests for the DisplayInfoOfSavedItems() method 

        //[TestMethod]
        //public void Test_DisplayInfoOfSavedItems_Value()
        //{

        //    // Arrange
        //    SearchedItem searched = new SearchedItem();
        //    SavedItem saved = new SavedItem();

        //    List<Item> testSavedItems = new List<Item>();

        //    Item Apple = new Item("Apple", "3.99", "Walmart", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg");

        //    // Act (make the methods that are being tested "public") 

        //    testSavedItems.Add(Apple);

        //    // Assert
        //    Assert.AreEqual(saved.savedItemNameTextBox.Text, Apple.name);
        //    Assert.AreEqual(saved.savedItemPriceTextBox.Text, Apple.price);
        //    Assert.AreEqual(saved.savedStoreNameTextBox.Text, Apple.store);

        //}

        //[TestMethod]
        //public void Test_DisplayInfoOfSavedItems_Check_Amount_Of_Items_In_SavedList()
        //{

        //    // Arrange
        //    SearchedItem searched = new SearchedItem();
        //    SavedItem saved = new SavedItem();

        //    List<Item> testSavedItems = new List<Item>();

        //    Item Apple = new Item("Apple", "3.99", "Walmart", "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg");
        //    Item Pear = new Item("Pear", "4.20", "TnT", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg");

        //    // Act

        //    testSavedItems.Add(Apple);
        //    testSavedItems.Add(Pear);

        //    // Assert
        //    int numberOfItemsInTheSavedItemsArray = testSavedItems.Count;

        //    Assert.AreEqual("2", numberOfItemsInTheSavedItemsArray);
        //}

        [TestMethod]
        public void Test_DisplayInfoOfSavedItems_ItemPrice()
        {

            // Arrange
            SearchedItem searched = new SearchedItem();
            SavedItem saved = new SavedItem("Pear", "4.20", "TnT");
            // Item Pear = new Item("Pear", "4.20", "TnT", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg");
            // Act
            TextBox savedResultItemPriceTextbox = searched.DisplayInfoOfSavedItems(saved.savedItemPriceTextBox);
            //testSavedItems.Add(Pear);

            // Assert
            // Assert.AreEqual(saved.savedItemPriceTextBox, searched.itemPriceTextBox);
            Assert.IsTrue(saved.savedItemPriceTextBox.Contains(savedResultItemPriceTextbox));
        }

        //[TestMethod]
        //public void Test_DisplayInfoOfSavedItems_ItemName()
        //{

        //  // Arrange
        //    SearchedItem searched = new SearchedItem();
        //    SavedItem saved = new SavedItem("Pear", "4.20", "TnT");
        //    Item Pear = new Item("Pear", "4.20", "TnT", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg");
            
        //    // Act
        //    TextBox savedResultItemNameTextbox = searched.DisplayInfoOfSavedItems(saved.savedItemNameTextBox);
        //    testSavedItems.Add(Pear);

        //    // Assert
        //    // Assert.AreEqual(saved.savedItemPriceTextBox, searched.itemPriceTextBox);
        //    Assert.IsTrue(saved.savedItemNameTextBox.Contains(savedResultItemNameTextbox));

        // }
              
            [TestMethod]
            public void Test_DisplayInfoOfSavedItems_Item_Store_Name()
            {

                // Arrange
                SearchedItem searched = new SearchedItem();
                SavedItem saved = new SavedItem("Pear", "4.20", "TnT");
                // Item Pear = new Item("Pear", "4.20", "TnT", "https://upload.wikimedia.org/wikipedia/commons/9/99/Four_pears.jpg");
                // Act
                TextBox savedResultItemStoreNameTextbox = searched.DisplayInfoOfSavedItems(saved.savedItemStoreNameTextBox);
                //testSavedItems.Add(Pear);

                // Assert
                // Assert.AreEqual(saved.savedItemPriceTextBox, searched.itemPriceTextBox);
                Assert.IsTrue(saved.savedStoreNameTextBox.Contains(savedResultItemStoreNameTextbox));
            }

     }
}
