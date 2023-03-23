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
    public partial class SavedItemsList : UserControl
    {

        JSONParser jsonParser = JSONParser.getInstance();
        public SavedItemsList()
        {
            InitializeComponent();
        }



        // Display SavedItems list from Json file using Bradner's Json Parser. 

        private void DisplaySavedItems(object sender, EventArgs e, ArrayList savedItems)
        {
            //ShowMainControls();

            //var savedItemsListJsonFile = File.ReadAllText(@"JSON_FILE_LINK");
            //var showSavedListJson = jsonParser.deserializeItems(savedItemsListJsonFile);

            //var savedItemsList = File.ReadAllText(@"JSON_FILE_LINK");
            //Item item = jsonParser.deserializeItems(savedItemsList);


            foreach (Item item in savedItems)
            {
                //string jsonString = JsonSerializer.Serialize(savedItems);
                jsonParser.deserializeItems();
            }

        }

    }
}
