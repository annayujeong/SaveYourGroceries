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
using SaveYourGroceriesLib;

namespace SaveYourGroceries
{
    public partial class MainForm : Form
    {
        WebScraper scraper = new WebScraper();

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

        // ------------------ OnClick method liked to the "Saved" button in MainForm ------------------- // 
        // This onClick method will reference two methods: on line 56 reference "SearchItem() subject to change.
        // Second method that must be created from scratch is the "DisplaySavedItems()" method as referenced on line 58.
        // Once this method is complete, link this method with the Saved button via the lightning bolt Click dropdown menu. 
    
        private void mainSavedButton_Click(object sender, EventArgs e)
        {
            ShowSaveControls();

              // ArrayList itemList = SearchItem(sender, e, this.savedListMenu.Text);
            // ArrayList itemList = scraper.SearchItem(sender, e, this.savedListMenu.Text);
            // ArrayList itemList = scraper.SearchItem(sender, e, this.itemNameTextBox.Text, this.itemPriceTextBox.Text);
            // ArrayList itemList = scraper.SearchItem(sender, e, this.mainPageSearchBox.Text);

            // this.mainPageSearchBox.Text = String.Empty;
            // DisplaySavedItems(sender, e, itemList);
        }
        // ------------------------------------------------------------------------------------------- // 
        private void DisplaySearchedItems(object sender, EventArgs e, ArrayList itemList)
        {
            SearchedItemsList searchedItemsList = new SearchedItemsList
            {
                Location = new Point(5, 50)
            };

            int itemBoxHeight = 150;
            int itemBoxGap = 5;


            // TODO: handle if an item is not found, or one or more properties is not found
            // -> current web parse methods all return an Item, even if that Item is null
            foreach (Item item in itemList)
            {
                SearchedItem searchedItem = new SearchedItem();
                searchedItem.itemNameTextBox.Text = item.name;
                searchedItem.itemPriceTextBox.Text = item.price;
                searchedItem.storeNameTextBox.Text = item.store;


                // temporary code to handle when Walmart blocks us lol, need to change
                if(item.imageUrl == null)
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

      // -------- DisplaySavedItems() : Will be based off DisplaySearchedItems() : ------------------------------------------------//

        //private void DisplaySavedItems(object sender, EventArgs e, ArrayList itemlist)
        //{
        //    SavedItemsList savedItemsList = new SavedItemsList
        //    {
        //        Location = new Point(5, 50)
        //    };

        //    int itemboxheight = 150;
        //    int itemboxgap = 5;


        //    // todo: handle if an item is not found, or one or more properties is not found
        //    // -> current web parse methods all return an item, even if that item is null
        //    foreach (Item item in itemlist)
        //    {
        //        SearchedItem searchedItem = new SearchedItem();
        //        // SavedItem savedItem = new SavedItem();
        //        searchedItem.itemNameTextBox.Text = item.name;
        //        // savedItem.itemNameTextBox.Text = item.name; 
        //        searchedItem.itemPriceTextBox.Text = item.price;
        //        // savedItem.itemPriceTextBox.Text = item.price;
        //        searchedItem.storeNameTextBox.Text = item.store;
        //        // savedItem.storeNameTextBox.Text = item.store;


        //        // temporary code to handle when walmart blocks us lol, need to change
        //        if (item.imageUrl == null)
        //        {
        //            searchedItem.itemPictureBox.Load("https://static.vecteezy.com/system/resources/thumbnails/000/536/310/small/food_paper_bag-01.jpg");
        //        }
        //        else
        //        {
        //            searchedItem.itemPictureBox.Load(item.imageUrl);
        //        }

        //        searchedItem.Location = new Point(5, itemboxgap);
        //        savedItemsList.Add(searchedItem);
        //        itemboxgap += itemboxheight;
        //    }

        //    this.Controls.Add(savedItemsList);
        //}


        // ------------------------------------------------------------------------------------ //

        private void ShowMainControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("mainPage") || controlName == "navBar")
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

        // Show Saved button, and NavBar while hiding all other control elements 
        private void ShowSaveControls()

        { string controlName;
          foreach (var control in Controls.OfType<Control>()) 
          { 
              controlName = control.Name;
              if (controlName.Contains("saved") || controlName == "searchPage" || controlName == "navBar")
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
