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

namespace SaveYourGroceriesLib
{
    public partial class SavedItemsList : UserControl
    {

        JSONParser jsonParser = JSONParser.getInstance();
        public SavedItemsList()
        {
            InitializeComponent();
        }

        public void Add(SavedItem searchedItem)
        {
            this.Controls.Add(searchedItem);
        }

        public void Remove(SavedItem searchedItem)
        {
            this.Controls.Remove(searchedItem);
        }
    }
}
