using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchedItems = SaveYourGroceries.SearchedItem;

namespace SaveYourGroceries
{

    public partial class SavedItem : UserControl
    {
        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;

        public SavedItem()
        {
            InitializeComponent();
        }

        private void saveItemToJSON(object sender, EventArgs e)
        {
            jsonParser.removeItem(item);
            MessageBox.Show(item.name);
            MessageBox.Show(jsonParser.getSavedItemsLength().ToString());
            jsonParser.deserializeItems();

        }


        public object IndexOf { get; private set; }

        //// Saves an Item to a Saved List in JSON format - References and uses the JSONParser.cs addItem and serialize method. 
        //private void saveItemToJsonList(object sender, EventArgs e, List<Item> savedListOfItems, SearchedItem savedGroceryListItem, ArrayList itemList)
        //{
        //    List<Item> savedItems = new List<Item>();
        //    SearchedItemsList searchedItemsList = new SearchedItemsList();

        //   // ------------------Array foreach loop-------------------- -
        //    {

        //        SavedItemsList savedItemsList = new SavedItemsList
        //        {
        //            Location = new Point(200, 40),
        //            Name = "savedItemsList"
        //        };

        //        int itemBoxHeight = 150;
        //        int itemBoxGap = 5;


        //        // TODO: handle if an item is not found, or one or more properties is not found
        //        // -> current web parse methods all return an Item, even if that Item is null
        //        foreach (Item item in searchedItemsList)
        //        {
        //            SearchedItem searchedItem = new SearchedItem();
        //            searchedItem.itemNameTextBox.Text = item.name;
        //            searchedItem.itemPriceTextBox.Text = item.price;
        //            searchedItem.storeNameTextBox.Text = item.store;


        //            // temporary code to handle when Walmart blocks us lol, need to change
        //            if (item.imageUrl == "")
        //            {
        //                searchedItem.itemPictureBox.Load("https://static.vecteezy.com/system/resources/thumbnails/000/536/310/small/food_paper_bag-01.jpg");
        //            }
        //            else
        //            {
        //                searchedItem.itemPictureBox.Load(item.imageUrl);
        //            }

        //            savedItem.Location = new Point(5, itemBoxGap);
        //            searchedItemsList.Add(searchedItem);
        //            itemBoxGap += itemBoxHeight;

        //            int savedGroceryItemIndex = IndexOf.Array(itemList, searchedItem);

        //            this.Controls.Add(savedItemsList);

        //            jsonParser.addItem(savedGroceryItem);
        //        }


        //        jsonParser.serializeItems();
        //    }

        //}
       
      }

   }
