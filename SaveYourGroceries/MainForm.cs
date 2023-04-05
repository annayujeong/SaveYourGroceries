using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SaveYourGroceriesLib;

namespace SaveYourGroceries
{
    public partial class MainForm : Form
    {
        WebScraper scraper = new WebScraper();
        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;
        public SavedItemsList savedItems; // Anna: why do we need global variables for this?

        ArrayList storesToSearch = new ArrayList();

        public MainForm()
        {
            InitializeComponent();
            ShowMainControls();
        }

        /// <summary>
        /// Handle searching functionality in the main (Search) page.
        /// It will display Search controls, call the web scraper and display the searched items control.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void mainSearchButton_Click(object sender, EventArgs e)
        {
            ShowSearchControls();

            ArrayList itemList = scraper.SearchItem(sender, e, this.mainPageSearchBox.Text, storesToSearch);
            this.mainPageSearchBox.Text = String.Empty;
            DisplaySearchedItems(itemList);
        }

        private void savedItemsButton_Click(object sender, EventArgs e)
        {
            ShowSaveControls();

            DisplaySavedItemList(sender, e, jsonParser.getSavedItems());
        }

        private void refreshSavedItemsListButton_Click(object sender, EventArgs e)
        {
            ShowSaveControls();

            DisplaySavedItemList(sender, e, jsonParser.getSavedItems());
        }

        /// <summary>
        /// Handle search functionality when inside of the searched items list.
        /// Call the web scraper and search for the items again.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void searchPageSearchButton_Click(object sender, EventArgs e)
        {
            ArrayList itemList = scraper.SearchItem(sender, e, this.searchPageSearchBox.Text, storesToSearch);
            this.searchPageSearchBox.Text = String.Empty;
            DisplaySearchedItems(itemList);
        }

        /// <summary>
        /// Show the main (Search) controls
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void searchMenu_Click(object sender, EventArgs e)
        {
            ShowMainControls();
        }

        /// <summary>
        /// Show the Settings controls.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void settingsMenu_Click(object sender, EventArgs e)
        {
            ShowSettingsControls();
        }


        // ---------------- Toggle Button functionality -------------------- // 

        /// <summary>
        /// Toggle buttons that displays / hides search results from the Searh Results page. 
        /// It provides users with a Message indicating the stores they will receive search results from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // ---------------- Toggle Button Superstore -------------------- // 

        private void toggleButtonSuperstore_Load(object sender, EventArgs e)
        {
            if (toggleButtonSuperstore.Check == true)
            {
                storesToSearch.Add(Store.Superstore.ToString());
                
                MessageBox.Show("You are now going to receive search results from Superstore!");


            }
            else if (toggleButtonSuperstore.Check == false)
            {
                MessageBox.Show("You are not going to receive search results from Superstore");
                            
                   storesToSearch.Remove(Store.Superstore.ToString());             
            }
        }

        // ---------------- Toggle Button Walmart -------------------- // 

        private void toggleButtonWalmart_Load(object sender, EventArgs e)
        {
            if (toggleButtonWalmart.Check == true)
            {
                storesToSearch.Add(Store.Walmart.ToString());
                MessageBox.Show("You are now going to receive search results from Walmart!");
            }

            else if (toggleButtonWalmart.Check == false)
            {
                MessageBox.Show("You are not going to receive search results from Walmart");
                storesToSearch.Remove(Store.Walmart.ToString());
            }
        }

        // ---------------- Toggle Button T&T -------------------- // 

        private void toggleButtonTnT_Load(object sender, EventArgs e)
        {
            if (toggleButtonTnT.Check == true)
            {
                storesToSearch.Add(Store.T_and_T.ToString());
                MessageBox.Show("You are now going to receive search results from T & T!");
            }
            else if (toggleButtonTnT.Check == false)
            {
                MessageBox.Show("You are not going to receive search results from T & T");
                storesToSearch.Remove(Store.T_and_T.ToString());
            }
        }

        // ---------------- Toggle Button Save on Foods -------------------- // 

        private void toggleButtonSaveOnFoods_Load(object sender, EventArgs e)
        {
            if (toggleButtonSaveOnFoods.Check == true)
            {
                storesToSearch.Add(Store.Save_On_Foods.ToString());
                MessageBox.Show("You are now going to receive search results from Save On Foods!");
            }
            else if (toggleButtonSaveOnFoods.Check == false)
            {
               MessageBox.Show("You are not going to receive search results from Save On Foods");
                storesToSearch.Remove(Store.Save_On_Foods.ToString());
            }     
        }

        /// <summary>
        /// Handle saving settings saving event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void settingsPageSaveButton_Click(object sender, EventArgs e)
        {
            ShowSettingsControls();
        }

        /// <summary>
        /// Scrap the item information from the selected stores 
        /// and create SearchedItemsList that will contain SearchedItem control
        /// </summary>
        /// <param name="itemList">item list in ArrayList</param>
        private void DisplaySearchedItems(ArrayList itemList)
        {
            if (this.Controls["searchedItemsList"] != null)
            {
                this.Controls.Remove(this.Controls["searchedItemsList"]);
            }

            SearchedItemsList searchedItemsList = new SearchedItemsList
            {
                Location = new Point(20, 50),
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
                if(item.imageUrl == "")
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

            //MessageBox.Show("Clicked");

            if (this.Controls["savedItemsList"] != null)
            {
                this.Controls.Remove(this.Controls["savedItemsList"]);
            }

            SavedItemsList savedItemsList = new SavedItemsList
            {
                Location = new Point(20, 50),
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
                //MessageBox.Show(item.name);
            }

            this.Controls.Add(savedItemsList);
        }

        /// <summary>
        /// Displays main (Search) controls only.
        /// </summary>
        private void ShowMainControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("mainPage") || controlName == "navBar" || controlName == "groupBoxCheckbox" || controlName == "toggleButtonSuperstore" || controlName == "toggleButtonWalmart" || controlName == "toggleButtonTnT" || controlName == "toggleButtonSaveOnFoods"
                                              || controlName == "labelToggleInstructions" || controlName == "labelForSuperstoreToggle" || controlName == "labelForWalmartToggle" || controlName == "labelForTnTToggle" || controlName == "labelForSaveOnFoodsToggle")
                                         
                {
                    control.Show();
                }
                else
                {
                    control.Hide();
                }
            }
        }

        /// <summary>
        /// Display Search page controls only.
        /// </summary>
        private void ShowSearchControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("searchPage") || controlName == "navBar" )
                                         
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
                if (controlName.Contains("savedItemsList") || controlName == "navBar" || controlName == "savedItemsListLabel" || controlName == "savedItemsListPageRefreshButton")
                {
                    control.Show();
                }
                else
                {
                    control.Hide();
                }
            }
        }

        /// <summary>
        /// Display Settings controls only.
        /// </summary>
        private void ShowSettingsControls()
        {
            string controlName;
            foreach (var control in Controls.OfType<Control>())
            {
                controlName = control.Name;
                if (controlName.Contains("settingsPage") || controlName == "navBar")
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
