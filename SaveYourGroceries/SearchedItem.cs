using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Item = SaveYourGroceriesLib.Item;


namespace SaveYourGroceries
{
    public partial class SearchedItem : UserControl
    {

        // Define the Constructor
        public SearchedItem()
        {
            InitializeComponent();
        }

        public SearchedItem(string stringx, string stringy, string stringz)
        {
            InitializeComponent();
       
        }

        public SearchedItem(Point Location)
        {
            InitializeComponent();
            this.Location = Location;

            // Inititialize the Controls

            storeNameTextBox = new System.Windows.Forms.TextBox();
            itemNameTextBox = new System.Windows.Forms.TextBox();
            itemPriceTextBox = new System.Windows.Forms.TextBox();
            itemPictureBox = new System.Windows.Forms.PictureBox();
            

            // Set the tab order, text alignment, size, and location of the controls.

            storeNameTextBox.Location = new System.Drawing.Point(333, 21);
            storeNameTextBox.Size = new System.Drawing.Size(384, 28);
            storeNameTextBox.TabIndex = 1;


            itemNameTextBox.Location = new System.Drawing.Point(333, 105);
            itemNameTextBox.Size = new System.Drawing.Size(384, 38);
            itemNameTextBox.TabIndex = 2;

            itemPriceTextBox.Location = new System.Drawing.Point(413, 157);
            itemPriceTextBox.Size = new System.Drawing.Size(304, 38);
            itemPriceTextBox.TabIndex = 3;

            itemPictureBox.Location = new System.Drawing.Point(24, 21);
            itemPriceTextBox.Size = new System.Drawing.Size(292, 262);

            // Add the controls to the user control.

            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                storeNameTextBox, itemNameTextBox, itemPriceTextBox, 
            });

            // Size the User Control 
            Size = new System.Drawing.Size();
        }

        // OnClick Button for the "Save" Button aka itemSaveButton 
        public void SaveItemFromResultsPageOnButton_Click(object sender, EventArgs e)
        //public void SaveItemFromResultsPageOnButton_Click(object sender, EventArgs e)
        {
            ArrayList savedItemList = new ArrayList();
            // ArrayList savedItemList = searchedStoreItem.SearchItem(sender, e, this.storeNameTextBox, this.itemNameTextBox, this.itemPriceTextBox);
            try
            { 
            savedItemList.Add(this.storeNameTextBox.Text);
            savedItemList.Add(this.itemNameTextBox.Text);
            savedItemList.Add(this.itemPriceTextBox.Text);
            savedItemList.Add(this.itemPictureBox);
                

            DisplayInfoOfSavedItems(sender, e, savedItemList);
            //DisplayInfoOfSavedItems(sender, e, savedItemList);

            } catch (ArgumentNullException ex)

            {
                MessageBox.Show("Item value inputted is not valid");
            }

            MessageBox.Show("Item has been added to your Saved Items List!");
            MessageBox.Show ($"There are {savedItemList.Count} elements in the list");
        }



        /// <summary>
        ///  DisplayInfoOfSavedItems() Method that displays info from the TextBox fields 
        ///  for SearchedItem.cs[Designer] (storeName, itemName, itemPrice) and displays
        ///  it in the TextBox fields for 
        ///  SavedItem.cs[Designer] (savedStoreName, savedItemName, savedItemPrice) 
        /// </summary>
        /// 
        /// <param name="ArrayList savedItemList"></param>
        /// <returns> savedItemList </returns>

        public void DisplayInfoOfSavedItems(object sender, EventArgs e, ArrayList savedItemList)
       //public void DisplayInfoOfSavedItems(object sender, EventArgs e, ArrayList savedItemList)
        {
            SavedGroceryStoreItemList savedItemsList = new SavedGroceryStoreItemList
            {
                Location = new Point(5, 50)
            };

            int itemBoxHeight = 150;
            int itemBoxGap = 5;


            foreach (Item groceryItem in savedItemList)
            {
                SavedItem savedItem = new SavedItem();

                savedItem.savedStoreNameTextBox.Text = storeNameTextBox.Text;
                savedItem.savedItemNameTextBox.Text = itemNameTextBox.Text;
                savedItem.savedItemPriceTextBox.Text = itemPriceTextBox.Text;
               
              

                savedItem.Location = new Point(5, itemBoxGap);
                savedItemsList.Add(savedItem);
                itemBoxGap += itemBoxHeight;
            }

            this.Controls.Add(savedItemsList);
        }

        //public string SaveItemFromResultsPageOnButton_Click(ArrayList testSavedItemStoreNameList)
        //{
        //    throw new NotImplementedException();
        //}
    }

}

