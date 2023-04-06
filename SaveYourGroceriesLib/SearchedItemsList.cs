using System.Windows.Forms;

/// <summary>
/// Author: Anna
/// Contain Searched Item List Control.
/// </summary>
namespace SaveYourGroceriesLib
{
    public partial class SearchedItemsList : UserControl
    {
        public SearchedItemsList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add SearchedItem to the control.
        /// </summary>
        /// <param name="searchedItem"></param>
        public void Add(SearchedItem searchedItem)
        {
            this.Controls.Add(searchedItem);
        }
    }
}
