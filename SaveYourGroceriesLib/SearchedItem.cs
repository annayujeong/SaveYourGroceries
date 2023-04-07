using System;
using System.Drawing;
using System.Windows.Forms;


namespace SaveYourGroceriesLib
{
    /// <summary>
    /// Author: Anna
    /// Contain Searched Item Control.
    /// </summary>
    public partial class SearchedItem : UserControl
    {
        JSONParser jsonParser = JSONParser.getInstance();
        public Item item;

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

        /// <summary>
        /// Saves an Item to a Saved List in JSON format - References and uses the JSONParser.cs addItem and serialize method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveItemToJSON(object sender, EventArgs e)
        {
            jsonParser.addItem(item);
            
            MessageBox.Show(item.name + "Has been added to the Saved List");
            jsonParser.serializeItems();
        }

    }

 }
