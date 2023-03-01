using System;
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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Item item = scraper.SearchItem(sender, e, this.searchBox.Text);

            this.itemNameBox.Text = item.name;
            this.itemPriceBox.Text = item.price;
            //this.itemPictureBox.Image = item.imageUrl;
           
        }
    }
}
