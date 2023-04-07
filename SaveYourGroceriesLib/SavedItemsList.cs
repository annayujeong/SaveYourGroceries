using System.Windows.Forms;


namespace SaveYourGroceriesLib
{
    /// <summary>
    /// Contains the Saved Item List control.
    /// Author: Kristopher
    /// </summary>
    public partial class SavedItemsList : UserControl
    {

        JSONParser jsonParser = JSONParser.getInstance();
        public SavedItemsList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add the saved item to the control.
        /// </summary>
        /// <param name="savedItem"></param>
        public void Add(SavedItem savedItem)
        {
            this.Controls.Add(savedItem);
        }

        /// <summary>
        /// Remove the saved item from the control.
        /// </summary>
        /// <param name="savedItem"></param>
        public void Remove(SavedItem savedItem)
        {
            this.Controls.Remove(savedItem);
        }
    }
}
