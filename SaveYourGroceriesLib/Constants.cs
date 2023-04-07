using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceriesLib
{
    /// <summary>
    /// This class is used to store constants for various classes in our application.
    /// Author: Bradner
    /// </summary>
    public static class Constants
    {
        // The name of Save Your Groceries' JSON file
        public static string JSON_FILE_NAME = "SaveYourGroceries.json";

        // The name of Save Your Groceries' JSON file used for testing
        public static string JSON_TEST_FILE_NAME = "SaveYourGroceriesTest.json";

        // Location of Save Your Groceries' JSON file
        // Should be roughly C:\Users\Home\AppData\Roaming
        public static string JSON_FILE_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            JSON_FILE_NAME);


        // Constants for HTML/CSS selectors for respective grocery store websites

        // Superstore
        public static string SUPERSTORE_ITEM_PRICE = "selling-price-list__item__price--now-price__value";
        public static string SUPERSTORE_ITEM_NAME = "product-name__item--name";
        public static string SUPERSTORE_ITEM_IMAGE = "responsive-image";
        public static string SUPERSTORE_ITEM_URL = "product-tile__details__info__name__link";

        // Save On Foods
        public static string SAVE_ON_FOODS_ITEM_PRICE = "ProductCardPrice--xq2y7a";
        public static string SAVE_ON_FOODS_ITEM_NAME = "sc-hKFyIo";
        public static string SAVE_ON_FOODS_ITEM_IMAGE = "ProductCardImage--qpr2ve";
        public static string SAVE_ON_FOODS_ITEM_URL = "ProductCardHiddenLink--v3c62m";

        // Walmart
        public static string WALMART_ITEM_PRICE = "css-2vqe5n";
        public static string WALMART_ITEM_NAME = "css-1p4va6y";
        public static string WALMART_ITEM_IMAGE = "css-19q6667";
        public static string WALMART_ITEM_URL = "e1m8uw911";

        // T & T Supermarket
        public static string TANDT_ITEM_PRICE = "item-price-zRu";
        public static string TANDT_ITEM_NAME = "item-name--yq";
        public static string TANDT_ITEM_IMAGE = "item-image-4D0";
        public static string TANDT_ITEM_URL = "item-images-Uve";
    }

    /// <summary>
    /// An enum which contains the list of store names.
    /// </summary>
    public enum Store
    {
       Superstore,
       Walmart,
       Save_On_Foods,
       T_and_T
    }
}
