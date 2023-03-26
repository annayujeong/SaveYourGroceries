using SaveYourGroceriesLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveYourGroceries
{
    public partial class SavedItemsList : UserControl
    {

        JSONParser jsonParser = JSONParser.getInstance();
        public SavedItemsList()
        {
            InitializeComponent();
        }

        internal void Add(SavedItem searchedItem)
        {
            this.Controls.Add(searchedItem);
        }

        internal void Remove(SavedItem searchedItem)
        {
            this.Controls.Remove(searchedItem);
        }
    }
}
