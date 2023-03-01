﻿using System;
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

        public Item() {}
        public Item(string name, string price, string imageUrl) {
            this.name = name;
            this.price = price;
            this.imageUrl = imageUrl;
        }
    }
}