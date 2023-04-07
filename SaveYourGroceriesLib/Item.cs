namespace SaveYourGroceriesLib
{
    /// <summary>
    /// This class represents a grocery store item, and contains the name, price, url of the item, the corresponding store,
    /// and the url for item to the website.
    /// Author: Bradner
    /// </summary>
    public class Item
    {
        public string name { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }

        public string store { get; set; }

        public string itemURL { get; set; }

        /// <summary>
        /// Item constructor with all atttributes set as empty strings by default.
        /// </summary>
        public Item() {
            this.name = "";
            this.price = "";
            this.imageUrl = "";
            this.store = "";
            this.itemURL = "";
        }

        /// <summary>
        /// Item constructor which takes in a name, price, image URL, store name, and an item URL.
        /// </summary>
        /// <param name="name">the item name</param>
        /// <param name="price">the item price</param>
        /// <param name="imageUrl">the URL for the item image</param>
        /// <param name="store">the store name</param>
        /// <param name="itemURL">the URL for the item</param>
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
