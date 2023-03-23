using OpenQA.Selenium.DevTools.V108.Debugger;
using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using JSONParser = SaveYourGroceriesLib.JSONParser;
using Item = SaveYourGroceriesLib.Item;



 namespace SaveYourGroceries
{
    public partial class SearchedItem : UserControl
    {

        //SearchedItem searchedItem = new SearchedItem();

        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;

        //public string resultName { get; set; }
        //public string resultPrice { get; set; }

        //public string resultStore { get; set; }

        //public SearchedItem(string itemNameValue, string itemPriceValue, string itemStoreNameValue)
        //{
        //    InitializeComponent();
        //}

        public SearchedItem(Item item)
        {
            this.item = item;
        }

        public SearchedItem(Point Location)
        {
            InitializeComponent();
            this.Location = Location;
        }

        public SearchedItem()
        {
            InitializeComponent();
        }

        private void saveItemToJSON(object sender, EventArgs e)
        {
            jsonParser.addItem(item);
            MessageBox.Show(item.name);
            MessageBox.Show(jsonParser.getSavedItemsLength().ToString());
            jsonParser.serializeItems();

        }

        //var searchedItem = new SearchedItem()
        //{
        //    searchedItemName = Convert.ToString(itemNameTextBox.Text),
        //    searchedItemPrice = Convert.ToString(itemPriceTextBox.Text),
        //    searchedItemStore = Convert.ToString(storeNameTextBox.Text)
        //}



        // Saves an Item to a Saved List in JSON format - References and uses the JSONParser.cs addItem and serialize method. 
        private void saveItemToJsonSavedList_Click(object sender, EventArgs e, List<Item> savedListOfItems, SearchedItem savedGroceryListItem, ArrayList itemList)
        {
            List<Item> savedItems = new List<Item>();

            string itemNameValue = Convert.ToString(itemNameTextBox.Text);
            string itemPriceValue = Convert.ToString(itemPriceTextBox.Text);
            string itemStoreNameValue = Convert.ToString(storeNameTextBox.Text);


            //var savedGroceryItem = new SearchedItem(itemNameTextBox.Text, itemPriceTextBox.Text, storeNameTextBox.Text);
            //var savedGroceryItem = new Item(itemNameValue, itemPriceValue, itemStoreNameValue);

            //savedItems.Add(savedGroceryItem);

            //jsonParser.addItem(savedGroceryItem);

            jsonParser.serializeItems();

            // Display Saved Item List after
            //MainForm.DisplaySavedItems();

         // ------------------  Array foreach loop  ---------------------
            //{
            //    if (this.Controls["searchedItemsList"] != null)
            //    {
            //        this.Controls.Remove(this.Controls["searchedItemsList"]);
            //    }

            //    SearchedItemsList searchedItemsList = new SearchedItemsList
            //    {
            //        Location = new Point(5, 50),
            //        Name = "searchedItemsList"
            //    };

            //    int itemBoxHeight = 150;
            //    int itemBoxGap = 5;


            //    // TODO: handle if an item is not found, or one or more properties is not found
            //    // -> current web parse methods all return an Item, even if that Item is null
            //    foreach (Item item in itemList)
            //    {
            //        SearchedItem searchedItem = new SearchedItem();
            //        searchedItem.itemNameTextBox.Text = item.name;
            //        searchedItem.itemPriceTextBox.Text = item.price;
            //        searchedItem.storeNameTextBox.Text = item.store;
                    

            //        // temporary code to handle when Walmart blocks us lol, need to change
            //        if (item.imageUrl == "")
            //        {
            //            searchedItem.itemPictureBox.Load("https://static.vecteezy.com/system/resources/thumbnails/000/536/310/small/food_paper_bag-01.jpg");
            //        }
            //        else
            //        {
            //            searchedItem.itemPictureBox.Load(item.imageUrl);
            //        }

            //        searchedItem.Location = new Point(5, itemBoxGap);
            //        savedItemsList.Add(searchedItem);
            //        itemBoxGap += itemBoxHeight;
            //    }

            //    this.Controls.Add(savedItemsList);

            //    jsonParser.addItem(savedGroceryItem);

            //    jsonParser.serializeItems();
            //}

         


            //class Item
            //{
            // var resultItem = new List<Item>();
            // itemName = DisplaySearchedItems().itemNameTextBox.Text;
            // itemPrice = itemPriceTextBox.Text;
            // itemStoreName = storeNameTextBox.Text;

            //    jsonParser.addItem(resultItem);
            // // this.itemSaveButton.Text = String.Empty;
            //jsonParser.serializeItems(sender, e, savedItems);

            //List<Item> previousItems;
            //try
            //{
            //    if(FileDialog.Exists(Constants.JSON_FILE_LOCATION))
            //    {
            //        previousItems = deserializeItems();

            //        if (previousItems != null)
            //        {
            //            savedItems = previousItems;
            //        }
            //    } else
            //    {
            //        createJSONFile();
            //    }
            //}

        }

    }

}

