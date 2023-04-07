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
    /// Author: Bradner
    /// Resources used/referenced: https://www.newtonsoft.com/json/help/html/Introduction.htm
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
        public JSONParser()
        {
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
                Console.WriteLine(Console.Error);
            }
            catch (ArgumentException)
            {
                createJSONFile();
            }
            catch (FileNotFoundException)
            {
                createJSONFile();
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

        /// <summary>
        /// Creates a JSON file at the given file location.
        /// </summary>
        public void createJSONFile()
        {
            using (StreamWriter sw = File.CreateText(Constants.JSON_FILE_LOCATION));
        }

        /// <summary>
        /// Adds the given item to the list of saved items if it doesn't already exist in the list.
        /// </summary>
        /// <param name="item"></param>
        public void addItem(Item item)
        {
            if (!savedItems.Contains(item))
            {
                savedItems.Add(item);
            }
        }

        /// <summary>
        /// Removes the given item from the list of saved items.
        /// </summary>
        /// <param name="item"></param>
        public void removeItem(Item item) { 
            savedItems.Remove(item);
        }

        /// <summary>
        /// Returns the length of the list of saved items.
        /// </summary>
        /// <returns></returns>
        public int getSavedItemsLength()
        {
            return savedItems.Count;
        }

        /// <summary>
        /// Reads from the JSON file at the given location and deserializes it into a list of Item objects.
        /// </summary>
        /// <returns>a list of Items</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public List<Item> deserializeItems()
        {
            var serializer = new JsonSerializer();

            if (JSONFileExists())
            { try
                {
                    using (var sw = new StreamReader(Constants.JSON_FILE_LOCATION))
                    using (var reader = new JsonTextReader(sw))
                    {

                        List<Item> deserializedItems = serializer.Deserialize<List<Item>>(reader);

                        savedItems = deserializedItems != null ? deserializedItems : savedItems;

                        return savedItems;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("This JSON file appears to be incorrectly formatted.");
                    throw new ArgumentException("This JSON file appears to be incorrectly formatted");
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
        public void serializeItems(List<Item> itemList=null, string fileLocation=null)
        {
            if (itemList == null)
            {
                itemList = this.savedItems;
            }
            if (fileLocation == null)
            {
                fileLocation = Constants.JSON_FILE_LOCATION;
            }
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(fileLocation))
                using (JsonWriter write = new JsonTextWriter(sw)) {
                serializer.Serialize(write, itemList);
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

        /// <summary>
        /// Converts the list of saved items into an array list.
        /// </summary>
        /// <returns></returns>
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
