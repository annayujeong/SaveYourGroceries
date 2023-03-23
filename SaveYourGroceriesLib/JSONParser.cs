using Newtonsoft.Json;
using OpenQA.Selenium.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SaveYourGroceriesLib
{

    /// <summary>
    /// This is a singleton implementation of a class responsible for reading and writing to 
    /// our application's JSON file.
    /// </summary>

    public class JSONParser
    {
        // singleton instance
        private static JSONParser instance;

        // list of items that will be serialized/deserialized
        private List<Item> savedItems = new List<Item>();

        /// <summary>
        /// Private constructor for singleton pattern. Loads data in existing JSON data if the
        /// file already exists.
        /// </summary>
        private JSONParser()
        {
            // TODO: Load in data from previous exisiting file
            //savedItems = deserializeItems();

            List<Item> previousItems;

            try { 

                if(File.Exists(Constants.JSON_FILE_LOCATION))
                {
                    previousItems = deserializeItems();

                    if (previousItems != null)
                    {
                        savedItems = previousItems;
                    }
                } else
                {
                    createJSONFile();
                }
            } catch (Newtonsoft.Json.JsonReaderException e)
            {

            }
        }

        /// <summary>
        /// Returns the JSONParser object if it already exists, otherwise creates
        /// one first.
        /// </summary>
        /// <returns>The JSONParser</returns>
        public static JSONParser getInstance()
        {
            if(instance == null)
            {
                instance = new JSONParser();
            } 
            return instance;
            
        }

        public void createJSONFile()
        {
            using (StreamWriter sw = File.CreateText(Constants.JSON_FILE_LOCATION)) ;
        }

        public void addItem(Item item)
        {
            if (!savedItems.Contains(item))
            {
                savedItems.Add(item);
            }
        }

        public void removeItem(Item item) { 
            savedItems.Remove(item);
        }

        public int getSavedItemsLength()
        {
            return savedItems.Count;
        }

        // return List<Item> or ArrayList()?
        public List<Item> deserializeItems()
        {
            var serializer = new JsonSerializer();

            if (JSONFileExists())
            { try
                {
                    using (var sw = new StreamReader(Constants.JSON_FILE_LOCATION))
                    using (var reader = new JsonTextReader(sw))
                    {

                        Console.WriteLine(savedItems == null);


                        List<Item> deserializedItems = serializer.Deserialize<List<Item>>(reader);

                        savedItems = deserializedItems != null ? deserializedItems : savedItems;

                        //Console.WriteLine(deserializedItems == null);

                        //savedItems = deserializedItems;

                        return savedItems;
                        //return serializer.Deserialize<List<Item>>(reader);
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("This JSON file appears to be incorrectly formatted.");
                    throw new Exception("This JSON file appears to be incorrectly formatted");
                }
            } else
            {
                throw new System.IO.FileNotFoundException();
            }
        }

        /// <summary>
        /// Serializes the current list of saved items into a JSON file at the
        /// specified location.
        /// </summary>
        public void serializeItems()
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(Constants.JSON_FILE_LOCATION))
                using (JsonWriter write = new JsonTextWriter(sw)) {
                serializer.Serialize(write, savedItems);
            }
        }

        /// <summary>
        /// Returns whether the JSON file already exists.
        /// </summary>
        /// <returns>true if the file exists at the specified location</returns>
        public Boolean JSONFileExists()
        {
            return File.Exists(Constants.JSON_FILE_LOCATION);
        }

        public ArrayList getSavedItems()
        {

            // type conversion

            ArrayList itemsToSend = new ArrayList();

            foreach(Item item in savedItems)
            {
                itemsToSend.Add(item);
            }

            return itemsToSend;
        }

        /// <summary>
        /// Clears the list of saved items.
        /// </summary>
        public void clearSavedItems()
        {
            savedItems.Clear();
        }
    }
}
