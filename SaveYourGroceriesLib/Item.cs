using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceriesLib
{
    /// <summary>
    /// This class represents a grocery store item, and contains the name, price, url of the item, the corresponding store,
    /// and the
    /// Author: Bradner
    /// </summary>
    public class Item
    {
        public string name { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }

        public string store { get; set; }

        public string itemURL { get; set; }

        public Item() {
            this.name = "";
            this.price = "";
            this.imageUrl = "";
            this.store = "";
            this.itemURL = "";
        }

        public Item(string name, string price, string imageUrl, string store, string itemURL)
        {
            this.name = name;
            this.price = price;
            this.imageUrl = imageUrl;
            this.store = store;
            this.itemURL = itemURL;
        }
    }
}
