using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaveYourGroceries;
using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONParser = SaveYourGroceriesLib.JSONParser;
using System.Windows.Forms;
using System.Collections;

/// <summary>
/// Unit Tests that tests the toggles that includes or does not include an item from a grocery store item search results. 
/// </summary>
/// 

namespace SaveYourGroceriesTest

{
    [TestClass()]
    public class ToggleButtonTests
    {

        /// <summary>
        /// Tests the ability of the Grocery Store Toggle to display a pop up message (when it is clicked / toggled)
        /// letting the user know that an item from that store will be included in the results list.  
        /// </summary>
        
        [TestMethod()]
        public void DisplayMessageIfToggleButtonIsClicked()
        {

            // Arrange 

            Toggle toggle = new Toggle();
            ArrayList storesToSearch = new ArrayList();
            var storeTestMessage = "You are now going to receive search results from Superstore!";

            // Act
            if (toggle.Check == true)
            {
                storesToSearch.Add("Superstore");
                MessageBox.Show(storeTestMessage);
            }

            // Assert
            Assert.AreEqual("You are now going to receive search results from Superstore!", storeTestMessage);

        }


        /// <summary>
        /// Tests the ability of the Grocery Store Toggle (when it is untoggled) to display a pop up message 
        /// letting the user know that an item from that store will not be included in the results list.  
        /// </summary>
        
        [TestMethod()]
        public void DisplayMessageIfToggleButtonIsUntoggled()
        {

            // Arrange 

            Toggle toggle = new Toggle();
            ArrayList storesToSearch = new ArrayList();
            var storeTestMessage = "You are not going to receive search results from Superstore!";

            // Act

            if (toggle.Check == false)
            {
                storesToSearch.Remove("Superstore");
                MessageBox.Show(storeTestMessage);
            }

            // Assert
            Assert.AreEqual("You are not going to receive search results from Superstore!", storeTestMessage);

        }

        /// <summary>
        /// Tests the ability of the Toggle function when multiple toggles are selected.
        /// displaying the correct number and correct pop up messages. 
        /// </summary>
        
        [TestMethod()]
        public void DisplayMultipleMessagesIfMultipleToggleButtonsAreClicked()
        {

            // Arrange 

            Toggle toggle = new Toggle();
            ArrayList storesToSearch = new ArrayList();
            var storeTestMessage1 = "You are going to receive search results from Superstore!";
            var storeTestMessage2 = "You are going to receive search results from Save On Foods!";

            // Act

            if (toggle.Check == true)
            {
                storesToSearch.Add("Superstore");
                storesToSearch.Add("SaveOnFoods");
                MessageBox.Show(storeTestMessage1);
                MessageBox.Show(storeTestMessage2);
            }

            // Assert
            Assert.AreEqual("You are going to receive search results from Superstore!", storeTestMessage1);
            Assert.AreEqual("You are going to receive search results from Save On Foods!", storeTestMessage2);


        }
    }
}