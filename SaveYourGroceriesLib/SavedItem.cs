using System;
using System.Windows.Forms;


namespace SaveYourGroceriesLib
{
    /// <summary>
    /// Contains the Saved Item control.
    /// Author: Kristopher
    /// </summary>
    public partial class SavedItem : UserControl
    {
        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;

        public SavedItem()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Removes an Item from the Saved List in JSON format - References and uses 
        /// the JSONParser's removeItem and deserialize method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void removeItemFromJSON(object sender, EventArgs e)
        {
            jsonParser.removeItem(item);
            MessageBox.Show(item.name + "Has been removed from the list");
            jsonParser.serializeItems();
            jsonParser.deserializeItems();
            jsonParser.getSavedItems();
        }
      }
   }
