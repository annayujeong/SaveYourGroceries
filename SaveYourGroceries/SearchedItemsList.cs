﻿using System;
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
    public partial class SearchedItemsList : UserControl
    {
        public SearchedItemsList()
        {
            InitializeComponent();
        }

        internal void Add(SearchedItem searchedItem)
        {
            this.Controls.Add(searchedItem);
        }
    }
}