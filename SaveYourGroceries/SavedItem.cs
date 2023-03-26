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


        /// <summary>
        /// Removes an Item from the Saved List in JSON format - References and uses 
        /// the JSONParser's removeItem and deserialize method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemFromJSON(object sender, EventArgs e)
        {
            jsonParser.removeItem(item);
            MessageBox.Show(item.name + "Has been removed from the list");
            jsonParser.serializeItems();
            jsonParser.deserializeItems();
            MessageBox.Show(jsonParser.getSavedItemsLength().ToString());
            jsonParser.getSavedItems();
          
        }
       
      }

   }
