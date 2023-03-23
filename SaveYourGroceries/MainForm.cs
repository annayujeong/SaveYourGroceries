using System;
//using System.Text.Json;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveYourGroceriesLib;
using Newtonsoft.Json;
using System.IO;

namespace SaveYourGroceries
{
    // TODO: Have JSONParser load in data from an existing JSON form
    // -> How to do a unit test for this?
    public partial class MainForm : Form
    {
        WebScraper scraper = new WebScraper();

        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;

        public SavedItemsList savedItems;

        public MainForm()
        {
            InitializeComponent();
            ShowMainControls();
        }

        // TODO: add loading indicator while driver is searching for the item
        // TODO: clear search results for previous search when user does a new search
        private void mainSearchButton_Click(object sender, EventArgs e)
        {
            ShowSearchControls();

            ArrayList itemList = scraper.SearchItem(sender, e, this.mainPageSearchBox.Text);
            this.mainPageSearchBox.Text = String.Empty;
            DisplaySearchedItems(sender, e, itemList);
        }

        private void savedItemsButton_Click(object sender, EventArgs e)
        {
            ShowSaveControls();

            DisplaySavedItemList(sender, e, jsonParser.getSavedItems());
        }

        private void searchPageSearchButton_Click(object sender, EventArgs e)
        {
            ArrayList itemList = scraper.SearchItem(sender, e, this.searchPageSearchBox.Text);
            this.searchPageSearchBox.Text = String.Empty;
            DisplaySearchedItems(sender, e, itemList);
        }

        private void searchMenu_Click(object sender, EventArgs e)
        {
            ShowMainControls();
        }



        private void DisplaySearchedItems(object sender, EventArgs e, ArrayList itemList)
        {
            if (this.Controls["searchedItemsList"] != null)
            {
                this.Controls.Remove(this.Controls["searchedItemsList"]);
            }

            SearchedItemsList searchedItemsList = new SearchedItemsList
            {
                Location = new Point(5, 50),
                Name = "searchedItemsList"
            };

            int itemBoxHeight = 150;
            int itemBoxGap = 5;


            // TODO: handle if an item is not found, or one or more properties is not found
            // -> current web parse methods all return an Item, even if that Item is null
            foreach (Item item in itemList)
            {
                SearchedItem searchedItem = new SearchedItem();
                searchedItem.item = item;
                searchedItem.itemNameTextBox.Text = item.name;
                searchedItem.itemPriceTextBox.Text = item.price;
                searchedItem.storeNameTextBox.Text = item.store;

                // temporary code to handle when Walmart blocks us lol, need to change
                if (item.imageUrl == "")
                {
                    searchedItem.itemPictureBox.Load("https://static.vecteezy.com/system/resources/thumbnails/000/536/310/small/food_paper_bag-01.jpg");
                } else
                {
                    searchedItem.itemPictureBox.Load(item.imageUrl);
                }

                searchedItem.Location = new Point(5, itemBoxGap);
                searchedItemsList.Add(searchedItem);
                itemBoxGap += itemBoxHeight;
            }

            this.Controls.Add(searchedItemsList);
        }




        // ----------  Display Saved Items List --------------------- //
        
        /// <summary>
        /// Displays Saved Items into a Empty UserControl (SavedItemsList) and populates it with 
        /// the information of the Saved Item. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="savedList"></param>
        public void DisplaySavedItemList(object sender, EventArgs e, ArrayList savedList)
        {

            MessageBox.Show("Clicked");

            if (this.Controls["savedItemsList"] != null)
            {
                this.Controls.Remove(this.Controls["savedItemsList"]);
            }

            SavedItemsList savedItemsList = new SavedItemsList
            {
                Location = new Point(5, 50),
                Name = "savedItemsList"
            };

            int itemBoxHeight = 150;
            int itemBoxGap = 5;


            // TODO: handle if an item is not found, or one or more properties is not found
            // -> current web parse methods all return an Item, even if that Item is null
            foreach (Item item in savedList)
            {
                SavedItem savedItem = new SavedItem();
                savedItem.item = item;
                savedItem.savedItemNameTextBox.Text = item.name;
                savedItem.savedItemPriceTextBox.Text = item.price;
                savedItem.savedItemStoreTextBox.Text = item.store;


                // temporary code to handle when Walmart blocks us lol, need to change
                if (item.imageUrl == "")
                {
                    savedItem.savedItemPictureBox.Load("https://static.vecteezy.com/system/resources/thumbnails/000/536/310/small/food_paper_bag-01.jpg");
                }
                else
                {
                    savedItem.savedItemPictureBox.Load(item.imageUrl);
                }

                savedItem.Location = new Point(5, itemBoxGap);
                itemBoxGap += itemBoxHeight;
                savedItemsList.Add(savedItem);
                MessageBox.Show(item.name);
            }

            this.Controls.Add(savedItemsList);
        }


        private void ShowMainControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("mainPage") || controlName == "navBar" || controlName == "savedGroceryItemsListBox")
                {
                    control.Show();
                }
                else
                {
                    control.Hide();
                }
            }
        }

        private void ShowSearchControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("searchPage") || controlName == "navBar")
                {
                    control.Show();
                }
                else
                {
                    control.Hide();
                }
            }
        }

        private void ShowSaveControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("savedItemsList") || controlName == "navBar")
                {
                    control.Show();
                }
                else
                {
                    control.Hide();
                }
            }
        }


    }
}
