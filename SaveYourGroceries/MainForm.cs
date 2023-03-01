using System;
using System.Collections;
using System.Windows.Forms;
using OpenQA.Selenium;
using SaveYourGroceriesLib;

namespace SaveYourGroceries
{
    public partial class MainForm : Form
    {
        WebScraper scraper = new WebScraper();
        public MainForm()
        {
            InitializeComponent();
            //WebScraper scraper = new WebScraper();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ArrayList items = scraper.SearchItem(sender, e, this.searchBox.Text);

            //this.itemNameBox.Text = item.name;
            //this.itemPriceBox.Text = item.price;
            //this.itemPictureBox.Image = item.imageUrl;
           
        }
    }
}
