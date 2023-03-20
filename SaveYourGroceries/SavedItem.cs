using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using OpenQA.Selenium.DevTools.V108.Debugger;
using SaveYourGroceriesLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveYourGroceries;

using System.Diagnostics.Tracing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Collections;
using Item = SaveYourGroceriesLib.Item;


namespace SaveYourGroceries
{

    public partial class SavedItem : UserControl
    {
        //public event EventHandler saveButtonClick;


        public SavedItem()
        {
            InitializeComponent();
        }
        public SavedItem(string v, string v1, string v2)
        {
            InitializeComponent();
        }

        public SavedItem(string v, Point location)
        {
            InitializeComponent();

            // Inititialize the Controls

            savedStoreNameTextBox = new System.Windows.Forms.TextBox();
            savedItemNameTextBox = new System.Windows.Forms.TextBox();
            savedItemPriceTextBox = new System.Windows.Forms.TextBox();
            savedItemPictureBox = new System.Windows.Forms.PictureBox();

            // Sets the tab order, text alignment, size, and location of the controls.
            // These co-ordinates correspond to the TextBox location, size, and index in SavedItem.cs[Design]

            // TextBox info for the saved item's Store Name
            savedStoreNameTextBox.Location = new System.Drawing.Point(343, 32);
            savedStoreNameTextBox.Size = new System.Drawing.Size(384, 45);
            savedStoreNameTextBox.TabIndex = 1;

            // TextBox info for the saved item's Name
            savedItemNameTextBox.Location = new System.Drawing.Point(343, 102);
            savedItemNameTextBox.Size = new System.Drawing.Size(384, 45);
            savedItemNameTextBox.TabIndex = 2;

            // TextBox info for the saved item's Price
            savedItemPriceTextBox.Location = new System.Drawing.Point(343, 190);
            savedItemPriceTextBox.Size = new System.Drawing.Size(384, 45);
            savedItemPriceTextBox.TabIndex = 3;

            // TextBox info for the saved item's PictureBox
            savedItemPictureBox.Location = new System.Drawing.Point(27, 21);
            savedItemPictureBox.Size = new System.Drawing.Size(293, 262);
           

            // Add the controls to the user control.

            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                savedStoreNameTextBox, savedItemNameTextBox, savedItemPriceTextBox, savedItemPictureBox
            });

            // Size the User Control 

            Size = new System.Drawing.Size();
        }

     

        /// <summary>
        /// Loads item values (Item: name, price, and store) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void load_Values_To_Form(object sender, EventArgs e, Button itemSaveButton)
        {
            var searchedGroceryItem = new SearchedItem();
            searchedGroceryItem.itemNameTextBox = savedItemNameTextBox;
            searchedGroceryItem.itemPriceTextBox = savedItemPriceTextBox;
            searchedGroceryItem.storeNameTextBox = savedStoreNameTextBox;
            searchedGroceryItem.itemPictureBox = savedItemPictureBox;

            //SearchedItem.saveButtonClick += new EventHandler(displayInfoOfSavedItem_OnSaveButtonClick);
        }



        // IMPORTANT Uncommented Copy of displayInfoOfSaveditems() just in case I am able to reference this from searched
        // item.cs 

        //private void displayInfoOfSavedItems(object sender, EventArgs e, ArrayList savedItemList)
        //{
        //    SavedItemsList savedItemsList = new SavedItemsList
        //    {
        //        Location = new Point(5, 50)
        //    };

        //    int itemBoxHeight = 150;
        //    int itemBoxGap = 5;


        //    // TODO: handle if an item is not found, or one or more properties is not found
        //    // -> current web parse methods all return an Item, even if that Item is null
        //    foreach (Item item in savedItemList)
        //    {
        //        SavedItem savedItem = new SavedItem();
        //        savedItem.savedItemNameTextBox.Text = item.name;
        //        savedItem.savedItemPriceTextBox.Text = item.price;
        //        savedItem.savedStoreNameTextBox.Text = item.store;

        //        savedItem.Location = new Point(5, itemBoxGap);
        //        savedItemsList.Add(savedItem);
        //        itemBoxGap += itemBoxHeight;
        //    }

        //    this.Controls.Add(savedItemsList);
        //}


    }
}
