using OpenQA.Selenium.DevTools.V108.Debugger;
using System;
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
    public partial class SearchedItem : UserControl
    {

        public SearchedItem()
        {
            InitializeComponent();
        }

        public SearchedItem(Point Location)
        {
            InitializeComponent();
            this.Location = Location;
        } 
    }
}
