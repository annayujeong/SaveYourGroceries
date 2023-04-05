using System.Windows.Forms;

namespace SaveYourGroceriesLib
{
    /// <summary>
    /// Author: Anna
    /// Contain Searched Item List Control.
    /// </summary>
    public partial class SearchedItemsList : UserControl
    {
        public SearchedItemsList()
        {
            InitializeComponent();
        }

        public void Add(SearchedItem searchedItem)
        {
            this.Controls.Add(searchedItem);
        }
    }
}
