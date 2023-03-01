using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SaveYourGroceriesTest
{
    [TestClass]
    public class Item

        // Unit test for Item() method that gets and sets the name, price, and ImageUrl of grocery item. 
    {
        [TestMethod]
        public void Item()
        {
        
       //Arrange 

        public string name { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }

        //Act 

        item.Item(string name, string price, string imageUrl);

        //Assert
        string actual = Item.Item (name, price, imageUrl);

    }
    }
}