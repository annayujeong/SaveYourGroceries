using System.Drawing;
using System.Windows.Forms;

namespace SaveYourGroceries
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPageSearchBox = new System.Windows.Forms.TextBox();
            this.savedListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.mainPageSearchButton = new System.Windows.Forms.Button();
            this.pageTitleTextBox = new System.Windows.Forms.TextBox();
            this.mainPageLogoBox = new System.Windows.Forms.PictureBox();
            this.searchPageSearchButton = new System.Windows.Forms.Button();
            this.searchPageSearchBox = new System.Windows.Forms.TextBox();
            this.savedGroceryItemsListBox = new System.Windows.Forms.ListBox();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPageSearchBox
            // 
            this.mainPageSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageSearchBox.Location = new System.Drawing.Point(31, 391);
            this.mainPageSearchBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainPageSearchBox.Name = "mainPageSearchBox";
            this.mainPageSearchBox.Size = new System.Drawing.Size(660, 67);
            this.mainPageSearchBox.TabIndex = 1;
            // 
            // savedListMenu
            // 
            this.savedListMenu.ForeColor = System.Drawing.Color.White;
            this.savedListMenu.Name = "savedListMenu";
            this.savedListMenu.Size = new System.Drawing.Size(121, 109);
            this.savedListMenu.Text = "Saved";
            // 
            // searchMenu
            // 
            this.searchMenu.ForeColor = System.Drawing.Color.White;
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(130, 109);
            this.searchMenu.Text = "Search";
            this.searchMenu.Click += new System.EventHandler(this.searchMenu_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.ForeColor = System.Drawing.Color.White;
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(149, 109);
            this.settingsMenu.Text = "Settings";
            // 
            // navBar
            // 
            this.navBar.AutoSize = false;
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.navBar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedListMenu,
            this.searchMenu,
            this.settingsMenu});
            this.navBar.Location = new System.Drawing.Point(0, 1100);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.navBar.Size = new System.Drawing.Size(891, 119);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "menuStrip1";
            // 
            // mainPageSearchButton
            // 
            this.mainPageSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.mainPageSearchButton.FlatAppearance.BorderSize = 0;
            this.mainPageSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.mainPageSearchButton.Location = new System.Drawing.Point(718, 384);
            this.mainPageSearchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainPageSearchButton.Name = "mainPageSearchButton";
            this.mainPageSearchButton.Size = new System.Drawing.Size(141, 74);
            this.mainPageSearchButton.TabIndex = 2;
            this.mainPageSearchButton.Text = "Go";
            this.mainPageSearchButton.UseVisualStyleBackColor = false;
            this.mainPageSearchButton.Click += new System.EventHandler(this.mainSearchButton_Click);
            // 
            // pageTitleTextBox
            // 
            this.pageTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pageTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageTitleTextBox.Enabled = false;
            this.pageTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pageTitleTextBox.Location = new System.Drawing.Point(32, 29);
            this.pageTitleTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageTitleTextBox.Name = "pageTitleTextBox";
            this.pageTitleTextBox.ReadOnly = true;
            this.pageTitleTextBox.Size = new System.Drawing.Size(827, 57);
            this.pageTitleTextBox.TabIndex = 3;
            this.pageTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPageLogoBox
            // 
            this.mainPageLogoBox.Image = global::SaveYourGroceries.Properties.Resources.logo;
            this.mainPageLogoBox.Location = new System.Drawing.Point(31, 153);
            this.mainPageLogoBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainPageLogoBox.Name = "mainPageLogoBox";
            this.mainPageLogoBox.Size = new System.Drawing.Size(827, 179);
            this.mainPageLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPageLogoBox.TabIndex = 4;
            this.mainPageLogoBox.TabStop = false;
            // 
            // searchPageSearchButton
            // 
            this.searchPageSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.searchPageSearchButton.FlatAppearance.BorderSize = 0;
            this.searchPageSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPageSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchPageSearchButton.Location = new System.Drawing.Point(717, 29);
            this.searchPageSearchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPageSearchButton.Name = "searchPageSearchButton";
            this.searchPageSearchButton.Size = new System.Drawing.Size(141, 74);
            this.searchPageSearchButton.TabIndex = 6;
            this.searchPageSearchButton.Text = "Go";
            this.searchPageSearchButton.UseVisualStyleBackColor = false;
            this.searchPageSearchButton.Click += new System.EventHandler(this.searchPageSearchButton_Click);
            // 
            // searchPageSearchBox
            // 
            this.searchPageSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPageSearchBox.Location = new System.Drawing.Point(32, 29);
            this.searchPageSearchBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPageSearchBox.Name = "searchPageSearchBox";
            this.searchPageSearchBox.Size = new System.Drawing.Size(660, 67);
            this.searchPageSearchBox.TabIndex = 5;
            // 
            // savedGroceryItemsListBox
            // 
            this.savedGroceryItemsListBox.FormattingEnabled = true;
            this.savedGroceryItemsListBox.ItemHeight = 31;
            this.savedGroceryItemsListBox.Items.AddRange(new object[] {
            "Saved Grocery Items List Box ",
            "",
            "Apple",
            "Orange",
            "Banana",
            "Bread",
            "Eggs ",
            "Milk "});
            this.savedGroceryItemsListBox.Location = new System.Drawing.Point(32, 484);
            this.savedGroceryItemsListBox.Name = "savedGroceryItemsListBox";
            this.savedGroceryItemsListBox.Size = new System.Drawing.Size(342, 252);
            this.savedGroceryItemsListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(891, 1219);
            this.Controls.Add(this.savedGroceryItemsListBox);
            this.Controls.Add(this.searchPageSearchButton);
            this.Controls.Add(this.searchPageSearchBox);
            this.Controls.Add(this.mainPageLogoBox);
            this.Controls.Add(this.pageTitleTextBox);
            this.Controls.Add(this.mainPageSearchButton);
            this.Controls.Add(this.mainPageSearchBox);
            this.Controls.Add(this.navBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainPageSearchBox;
        private System.Windows.Forms.ToolStripMenuItem savedListMenu;
        private System.Windows.Forms.ToolStripMenuItem searchMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.Button mainPageSearchButton;
        private System.Windows.Forms.TextBox pageTitleTextBox;
        private System.Windows.Forms.PictureBox mainPageLogoBox;
        private Button searchPageSearchButton;
        private TextBox searchPageSearchBox;
        private ListBox savedGroceryItemsListBox;
    }
}