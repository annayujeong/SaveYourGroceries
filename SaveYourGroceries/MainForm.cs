using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
            List<Item> itemList = scraper.SearchItem(sender, e, this.searchBox.Text);

            int groupPointX = 15;
            int groupPointY = 100;
            int gapGroup = 220;

            int childPointX = 15;
            int childPointY = 25;
            int gapChild = 25;

            foreach (Item item in itemList)
            {
                PictureBox itemPictureBox = new PictureBox
                {
                    Size = new Size(200, 100),
                    BackColor = Color.Blue,
                    Location = new Point(childPointX, childPointY),
                    TabIndex = 2
                };
                TextBox itemNameTextBox = new TextBox
                {
                    Text = item.name,
                    Location = new Point(childPointX, childPointY += 90 + gapChild),
                    TabIndex = 2
                };
                TextBox itemPriceTextBox = new TextBox
                {
                    Text = item.price,
                    Location = new Point(childPointX, childPointY += gapChild),
                    TabIndex = 2
                };
                TextBox itemStoreTextBox = new TextBox
                {
                    Text = item.price,
                    Location = new Point(childPointX, childPointY += gapChild),
                    TabIndex = 2
                };

                GroupBox itemBox = new GroupBox
                {
                    Size = new Size(300, 220),
                    Location = new Point(groupPointX, groupPointY),
                    TabIndex = 3
                };

                groupPointY += gapGroup;

                itemBox.Controls.Add(itemPictureBox);
                itemBox.Controls.Add(itemNameTextBox);
                itemBox.Controls.Add(itemPriceTextBox);
                itemBox.Controls.Add(itemStoreTextBox);

                this.Controls.Add(itemBox);

                childPointY = 15;
            }

        }
    }
}
