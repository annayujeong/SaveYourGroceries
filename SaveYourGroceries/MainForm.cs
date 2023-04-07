using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SaveYourGroceriesLib;


namespace SaveYourGroceries
{
    ///<summary>
    /// The UI for our application's main page.
    /// Authors: Anna, Bradner, Kristopher
    ///</summary>
    public partial class MainForm : Form
    {
        WebScraper scraper = new WebScraper();
        JSONParser jsonParser = JSONParser.getInstance();
        
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

        /// <summary>
        /// Displays the page for the user's currently saved items.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void savedItemsButton_Click(object sender, EventArgs e)
        {
            ShowSaveControls();
            DisplaySavedItemList(sender, e, jsonParser.getSavedItems());
        }

        /// <summary>
        /// Refresh the UI of the saved items page.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
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

        /// <summary>
        /// Changes whether Superstore should be inclued as a store in a search query
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void toggleButtonSuperstore_Load(object sender, EventArgs e)
        {
            if (toggleButtonSuperstore.Check == true)
            {
                storesToSearch.Add(Store.Superstore.ToString());
            }
            else if (toggleButtonSuperstore.Check == false)
            {
                   storesToSearch.Remove(Store.Superstore.ToString());             
            }
        }

        /// <summary>
        /// Changes whether Walmrat should be inclued as a store in a search query
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void toggleButtonWalmart_Load(object sender, EventArgs e)
        {
            if (toggleButtonWalmart.Check == true)
            {
                storesToSearch.Add(Store.Walmart.ToString());
            }
            else if (toggleButtonWalmart.Check == false)
            {
                storesToSearch.Remove(Store.Walmart.ToString());
            }
        }

        /// <summary>
        /// Changes whether T and T should be inclued as a store in a search query
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void toggleButtonTnT_Load(object sender, EventArgs e)
        {
            if (toggleButtonTnT.Check == true)
            {
                storesToSearch.Add(Store.T_and_T.ToString());
            }
            else if (toggleButtonTnT.Check == false)
            {
                storesToSearch.Remove(Store.T_and_T.ToString());
            }
        }

        /// <summary>
        /// Changes whether Save on Foods should be inclued as a store in a search query
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void toggleButtonSaveOnFoods_Load(object sender, EventArgs e)
        {
            if (toggleButtonSaveOnFoods.Check == true)
            {
                storesToSearch.Add(Store.Save_On_Foods.ToString());
            }
            else if (toggleButtonSaveOnFoods.Check == false)
            {
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

            foreach (Item item in itemList)
            {
                SearchedItem searchedItem = new SearchedItem();
                searchedItem.item = item;
                searchedItem.itemNameTextBox.Text = item.name;
                searchedItem.itemPriceTextBox.Text = item.price;
                searchedItem.storeNameTextBox.Text = item.store;

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
        
        /// <summary>
        /// Displays Saved Items into a Empty UserControl (SavedItemsList) and populates it with 
        /// the information of the Saved Item. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="savedList"></param>
        public void DisplaySavedItemList(object sender, EventArgs e, ArrayList savedList)
        {
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

            foreach (Item item in savedList)
            {
                SavedItem savedItem = new SavedItem();
                savedItem.item = item;
                savedItem.savedItemNameTextBox.Text = item.name;
                savedItem.savedItemPriceTextBox.Text = item.price;
                savedItem.savedItemStoreTextBox.Text = item.store;

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

        /// <summary>
        /// Display Save controls only.
        /// </summary>
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
