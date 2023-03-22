using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceriesLib
{
    public class Item
    {
        public string name { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }

        public string store { get; set; }

        public string itemURL { get; set; }
        public string ItemNameValue { get; }
        public string ItemPriceValue { get; }
        public string ItemStoreNameValue { get; }

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

        public Item(string itemNameValue, string itemPriceValue, string itemStoreNameValue)
        {
            ItemNameValue = itemNameValue;
            ItemPriceValue = itemPriceValue;
            ItemStoreNameValue = itemStoreNameValue;
        }
    }
}
