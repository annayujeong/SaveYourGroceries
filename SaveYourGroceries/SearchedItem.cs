using OpenQA.Selenium.DevTools.V108.Debugger;
using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using JSONParser = SaveYourGroceriesLib.JSONParser;
using Item = SaveYourGroceriesLib.Item;



 namespace SaveYourGroceries
{
    public partial class SearchedItem : UserControl
    {

        //SearchedItem searchedItem = new SearchedItem();

        JSONParser jsonParser = JSONParser.getInstance();

        public Item item;

        //public string resultName { get; set; }
        //public string resultPrice { get; set; }

        //public string resultStore { get; set; }

        //public SearchedItem(string itemNameValue, string itemPriceValue, string itemStoreNameValue)
        //{
        //    InitializeComponent();
        //}

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
        private void saveItemToJSON(object sender, EventArgs e)
        {
            jsonParser.addItem(item);
            
            MessageBox.Show(item.name + "Has been added to the Saved List");
            MessageBox.Show(jsonParser.getSavedItemsLength().ToString());
            jsonParser.serializeItems();
            

        }

    }

 }



