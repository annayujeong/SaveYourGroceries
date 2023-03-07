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

        private void DisplaySearchedItems(object sender, EventArgs e, ArrayList itemList)
        {
            SearchedItemsList searchedItemsList = new SearchedItemsList
            {
                Location = new Point(5, 50)
            };

            int itemBoxHeight = 150;
            int itemBoxGap = 5;

            foreach (Item item in itemList)
            {
                SearchedItem searchedItem = new SearchedItem();
                searchedItem.itemNameTextBox.Text = item.name;
                searchedItem.itemPriceTextBox.Text = item.price;
                searchedItem.storeNameTextBox.Text = item.store;
                searchedItem.itemPictureBox.Load(item.imageUrl);
                searchedItem.Location = new Point(5, itemBoxGap);
                searchedItemsList.Add(searchedItem);
                itemBoxGap += itemBoxHeight;
            }

            this.Controls.Add(searchedItemsList);
        }

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

    }
}
