using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SaveYourGroceries
{
    public partial class SavedGroceryItem : Form
    {
        private readonly string _path = // $"\"C:\\Users\\kriso\\Downloads\\SavedGroceryStoreItemList.json";
                                        $"\"C:\\Users\\kriso\\source\\repos\\annayujeong\\SaveYourGroceries\\SaveYourGroceries\\SavedGroceryStoreItemList.json";

        public SavedGroceryItem()
        {
            InitializeComponent();
        }

        private void buttonReadJSONFile_OnClick(object sender, EventArgs e)
        {
          try 
          {
           string jsonFromFile;
           using (var reader = new StreamReader(_path))
           {
            jsonFromFile = reader.ReadToEnd();
           }

          // Richtextbox refers to the Designer element rich textbox https://www.c-sharpcorner.com/UploadFile/mahesh/richtextbox-in-C-Sharp/
                savedItemListRichTextBox.Text = jsonFromFile;
           var savedItemInfoFromJson = JsonConvert.DeserializeObject<SavedGroceryStoreItemList>(jsonFromFile);
           
          }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void buttonWriteJSON_Click(object sender, EventArgs e)
        {
            try
            {
                var savedGroceryStoreItem = GetInfoOfSavedItems();
                var jsonToWrite = JsonConvert.SerializeObject(savedGroceryStoreItem, Formatting.Indented);
                using(var writer = new StreamWriter(_path))
                {
                    writer.Write(jsonToWrite);
                }
            }

            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private SavedGroceryStoreItem GetInfoOfSavedItems()
        {
            var savedGroceryStoreItem = new SavedGroceryStoreItem
            {
                     savedItemName = "Apple",
                     savedItemPrice = "3.99",
                     savedItemStoreName = "Superstore",
                     savedItemImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/07/Whole_apple_and_bitten_apple.jpg"

            };

            return savedGroceryStoreItem;
        }


        //private SavedGroceryStoreItemList GetInfoOfSavedItems()
        //{
        //    var savedGroceryStoreItem = new SavedGroceryStoreItem
        //    {
        //        SavedListOfItems = new List<SavedGroceryStoreItem>
        //        {
        //            new SavedGroceryStoreItem
        //            {
        //             savedItemName = "Apple",
        //             savedItemPrice = "3.99",
        //             savedItemStoreName = "Superstore",
        //             savedItemImageUrl = ""
        //            }
        //        }


        //    };

        //    return savedGroceryStoreItem;
        //}


    }

    public class SavedGroceryStoreItem
    {
        public string savedItemName { get; set; }
        public string savedItemPrice { get; set; }

        public string savedItemStoreName { get; set; }

        public string savedItemImageUrl { get; set; }
        public List<SavedGroceryStoreItem> SavedListOfItems { get; internal set; }
    }
}


