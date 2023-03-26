using System;
using System.Configuration;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.labelToggleInstructions = new System.Windows.Forms.Label();
            this.labelForSuperstoreToggle = new System.Windows.Forms.Label();
            this.labelForWalmartToggle = new System.Windows.Forms.Label();
            this.labelForTnTToggle = new System.Windows.Forms.Label();
            this.labelForSaveOnFoodsToggle = new System.Windows.Forms.Label();
            this.settingsPageTitleLabel = new System.Windows.Forms.Label();
            this.settingsPageNotificationLabel = new System.Windows.Forms.Label();
            this.settingsPageNotificationCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsPageSaveButton = new System.Windows.Forms.Button();
            this.savedItemsListLabel = new System.Windows.Forms.Label();
            this.toggleButtonSaveOnFoods = new SaveYourGroceries.Toggle();
            this.toggleButtonTnT = new SaveYourGroceries.Toggle();
            this.toggleButtonWalmart = new SaveYourGroceries.Toggle();
            this.toggleButtonSuperstore = new SaveYourGroceries.Toggle();
            this.savedItemsListPageRefreshButton = new System.Windows.Forms.Button();
            this.settingsPage = new SaveYourGroceries.SettingsPage();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPageSearchBox
            // 
            this.mainPageSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageSearchBox.Location = new System.Drawing.Point(12, 195);
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
            this.savedListMenu.Click += new System.EventHandler(this.savedItemsButton_Click);
            // 
            // searchMenu
            // 
            this.searchMenu.ForeColor = System.Drawing.Color.White;
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(54, 46);
            this.searchMenu.Text = "Search";
            this.searchMenu.Click += new System.EventHandler(this.searchMenu_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.ForeColor = System.Drawing.Color.White;
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 46);
            this.settingsMenu.Text = "Settings";
            this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
            // 
            // navBar
            // 
            this.navBar.AutoSize = false;
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navBar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedListMenu,
            this.searchMenu,
            this.settingsMenu});
            this.navBar.Location = new System.Drawing.Point(0, 456);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(332, 50);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "menuStrip1";
            // 
            // mainPageSearchButton
            // 
            this.mainPageSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.mainPageSearchButton.FlatAppearance.BorderSize = 0;
            this.mainPageSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageSearchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.mainPageSearchButton.Location = new System.Drawing.Point(269, 196);
            this.mainPageSearchButton.Name = "mainPageSearchButton";
            this.mainPageSearchButton.Size = new System.Drawing.Size(53, 31);
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
            this.pageTitleTextBox.Location = new System.Drawing.Point(12, 12);
            this.pageTitleTextBox.Name = "pageTitleTextBox";
            this.pageTitleTextBox.ReadOnly = true;
            this.pageTitleTextBox.Size = new System.Drawing.Size(310, 23);
            this.pageTitleTextBox.TabIndex = 3;
            this.pageTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPageLogoBox
            // 
            this.mainPageLogoBox.Image = global::SaveYourGroceries.Properties.Resources.logo;
            this.mainPageLogoBox.Location = new System.Drawing.Point(12, 95);
            this.mainPageLogoBox.Name = "mainPageLogoBox";
            this.mainPageLogoBox.Size = new System.Drawing.Size(310, 75);
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
            this.searchPageSearchButton.Location = new System.Drawing.Point(269, 12);
            this.searchPageSearchButton.Name = "searchPageSearchButton";
            this.searchPageSearchButton.Size = new System.Drawing.Size(53, 31);
            this.searchPageSearchButton.TabIndex = 6;
            this.searchPageSearchButton.Text = "Go";
            this.searchPageSearchButton.UseVisualStyleBackColor = false;
            this.searchPageSearchButton.Click += new System.EventHandler(this.searchPageSearchButton_Click);
            // 
            // searchPageSearchBox
            // 
            this.searchPageSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPageSearchBox.Location = new System.Drawing.Point(12, 12);
            this.searchPageSearchBox.Name = "searchPageSearchBox";
            this.searchPageSearchBox.Size = new System.Drawing.Size(250, 31);
            this.searchPageSearchBox.TabIndex = 5;
            // 
            // settingsPage
            // labelToggleInstructions
            // 
            this.labelToggleInstructions.AutoSize = true;
            this.labelToggleInstructions.Location = new System.Drawing.Point(25, 510);
            this.labelToggleInstructions.Name = "labelToggleInstructions";
            this.labelToggleInstructions.Size = new System.Drawing.Size(804, 32);
            this.labelToggleInstructions.TabIndex = 20;
            this.labelToggleInstructions.Text = "Select a Grocery store you would like to get search results from";
            // 
            // labelForSuperstoreToggle
            // 
            this.labelForSuperstoreToggle.AutoSize = true;
            this.labelForSuperstoreToggle.Location = new System.Drawing.Point(123, 557);
            this.labelForSuperstoreToggle.Name = "labelForSuperstoreToggle";
            this.labelForSuperstoreToggle.Size = new System.Drawing.Size(153, 32);
            this.labelForSuperstoreToggle.TabIndex = 21;
            this.labelForSuperstoreToggle.Text = "Superstore";
            // 
            // labelForWalmartToggle
            // 
            this.labelForWalmartToggle.AutoSize = true;
            this.labelForWalmartToggle.Location = new System.Drawing.Point(123, 620);
            this.labelForWalmartToggle.Name = "labelForWalmartToggle";
            this.labelForWalmartToggle.Size = new System.Drawing.Size(119, 32);
            this.labelForWalmartToggle.TabIndex = 22;
            this.labelForWalmartToggle.Text = "Walmart";
            // 
            // labelForTnTToggle
            // 
            this.labelForTnTToggle.AutoSize = true;
            this.labelForTnTToggle.Location = new System.Drawing.Point(123, 682);
            this.labelForTnTToggle.Name = "labelForTnTToggle";
            this.labelForTnTToggle.Size = new System.Drawing.Size(64, 32);
            this.labelForTnTToggle.TabIndex = 23;
            this.labelForTnTToggle.Text = "TnT";
            // 
            // labelForSaveOnFoodsToggle
            // 
            this.labelForSaveOnFoodsToggle.AutoSize = true;
            this.labelForSaveOnFoodsToggle.Location = new System.Drawing.Point(123, 745);
            this.labelForSaveOnFoodsToggle.Name = "labelForSaveOnFoodsToggle";
            this.labelForSaveOnFoodsToggle.Size = new System.Drawing.Size(210, 32);
            this.labelForSaveOnFoodsToggle.TabIndex = 24;
            this.labelForSaveOnFoodsToggle.Text = "Save On Foods";
            // 
            // settingsPageTitleLabel
            // 
            this.settingsPageTitleLabel.AutoSize = true;
            this.settingsPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.settingsPageTitleLabel.Location = new System.Drawing.Point(32, 31);
            this.settingsPageTitleLabel.Name = "settingsPageTitleLabel";
            this.settingsPageTitleLabel.Size = new System.Drawing.Size(223, 63);
            this.settingsPageTitleLabel.TabIndex = 8;
            this.settingsPageTitleLabel.Text = "Settings";
            // 
            // settingsPageNotificationLabel
            // 
            this.settingsPageNotificationLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsPageNotificationLabel.Name = "settingsPageNotificationLabel";
            this.settingsPageNotificationLabel.Size = new System.Drawing.Size(84, 19);
            this.settingsPageNotificationLabel.TabIndex = 12;
            // 
            // settingsPageNotificationCheckbox
            // 
            this.settingsPageNotificationCheckbox.AutoSize = true;
            this.settingsPageNotificationCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsPageNotificationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPageNotificationCheckbox.Location = new System.Drawing.Point(54, 153);
            this.settingsPageNotificationCheckbox.Name = "settingsPageNotificationCheckbox";
            this.settingsPageNotificationCheckbox.Size = new System.Drawing.Size(719, 44);
            this.settingsPageNotificationCheckbox.TabIndex = 10;
            this.settingsPageNotificationCheckbox.Text = "Get push notification on finding lower price";
            this.settingsPageNotificationCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsPageSaveButton
            // 
            this.settingsPageSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.settingsPageSaveButton.FlatAppearance.BorderSize = 0;
            this.settingsPageSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsPageSaveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.settingsPageSaveButton.Location = new System.Drawing.Point(718, 331);
            this.settingsPageSaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.settingsPageSaveButton.Name = "settingsPageSaveButton";
            this.settingsPageSaveButton.Size = new System.Drawing.Size(141, 74);
            this.settingsPageSaveButton.TabIndex = 11;
            this.settingsPageSaveButton.Text = "Save";
            this.settingsPageSaveButton.UseVisualStyleBackColor = false;
            this.settingsPageSaveButton.Click += new System.EventHandler(this.settingsPageSaveButton_Click);
            this.settingsPage.Location = new System.Drawing.Point(0, 1);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(332, 454);
            this.settingsPage.State = System.Windows.Forms.CheckState.Unchecked;
            this.settingsPage.TabIndex = 7;
            this.settingsPage.Hide();
            // 
            // savedItemsListLabel
            // 
            this.savedItemsListLabel.AutoSize = true;
            this.savedItemsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedItemsListLabel.Location = new System.Drawing.Point(23, 81);
            this.savedItemsListLabel.Name = "savedItemsListLabel";
            this.savedItemsListLabel.Size = new System.Drawing.Size(295, 39);
            this.savedItemsListLabel.TabIndex = 25;
            this.savedItemsListLabel.Text = "Your Saved Items:";
            // 
            // toggleButtonSaveOnFoods
            // 
            this.toggleButtonSaveOnFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonSaveOnFoods.BackgroundImage")));
            this.toggleButtonSaveOnFoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleButtonSaveOnFoods.Check = false;
            this.toggleButtonSaveOnFoods.Location = new System.Drawing.Point(30, 745);
            this.toggleButtonSaveOnFoods.Name = "toggleButtonSaveOnFoods";
            this.toggleButtonSaveOnFoods.Size = new System.Drawing.Size(65, 40);
            this.toggleButtonSaveOnFoods.TabIndex = 19;
            this.toggleButtonSaveOnFoods.Click += new System.EventHandler(this.toggleButtonSaveOnFoods_Load);
            // 
            // toggleButtonTnT
            // 
            this.toggleButtonTnT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonTnT.BackgroundImage")));
            this.toggleButtonTnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleButtonTnT.Check = false;
            this.toggleButtonTnT.Location = new System.Drawing.Point(30, 682);
            this.toggleButtonTnT.Name = "toggleButtonTnT";
            this.toggleButtonTnT.Size = new System.Drawing.Size(65, 40);
            this.toggleButtonTnT.TabIndex = 18;
            this.toggleButtonTnT.Click += new System.EventHandler(this.toggleButtonTnT_Load);
            // 
            // toggleButtonWalmart
            // 
            this.toggleButtonWalmart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonWalmart.BackgroundImage")));
            this.toggleButtonWalmart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleButtonWalmart.Check = false;
            this.toggleButtonWalmart.Location = new System.Drawing.Point(30, 620);
            this.toggleButtonWalmart.Name = "toggleButtonWalmart";
            this.toggleButtonWalmart.Size = new System.Drawing.Size(65, 40);
            this.toggleButtonWalmart.TabIndex = 17;
            this.toggleButtonWalmart.Click += new System.EventHandler(this.toggleButtonWalmart_Load);
            // 
            // toggleButtonSuperstore
            // 
            this.toggleButtonSuperstore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonSuperstore.BackgroundImage")));
            this.toggleButtonSuperstore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleButtonSuperstore.Check = false;
            this.toggleButtonSuperstore.Location = new System.Drawing.Point(30, 557);
            this.toggleButtonSuperstore.Name = "toggleButtonSuperstore";
            this.toggleButtonSuperstore.Size = new System.Drawing.Size(65, 40);
            this.toggleButtonSuperstore.TabIndex = 14;
            this.toggleButtonSuperstore.Click += new System.EventHandler(this.toggleButtonSuperstore_Load);
            // 
            // savedItemsListPageRefreshButton
            // 
            this.savedItemsListPageRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.savedItemsListPageRefreshButton.FlatAppearance.BorderSize = 0;
            this.savedItemsListPageRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedItemsListPageRefreshButton.ForeColor = System.Drawing.SystemColors.Window;
            this.savedItemsListPageRefreshButton.Location = new System.Drawing.Point(338, 65);
            this.savedItemsListPageRefreshButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemsListPageRefreshButton.Name = "savedItemsListPageRefreshButton";
            this.savedItemsListPageRefreshButton.Size = new System.Drawing.Size(141, 74);
            this.savedItemsListPageRefreshButton.TabIndex = 26;
            this.savedItemsListPageRefreshButton.Text = "Refresh Page";
            this.savedItemsListPageRefreshButton.UseVisualStyleBackColor = false;
            this.savedItemsListPageRefreshButton.Click += new System.EventHandler(this.refreshSavedItemsListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(891, 1219);
            this.Controls.Add(this.savedItemsListPageRefreshButton);
            this.Controls.Add(this.savedItemsListLabel);
            this.Controls.Add(this.labelForSaveOnFoodsToggle);
            this.Controls.Add(this.labelForTnTToggle);
            this.Controls.Add(this.labelForWalmartToggle);
            this.Controls.Add(this.labelForSuperstoreToggle);
            this.Controls.Add(this.labelToggleInstructions);
            this.Controls.Add(this.toggleButtonSaveOnFoods);
            this.Controls.Add(this.toggleButtonTnT);
            this.Controls.Add(this.toggleButtonWalmart);
            this.Controls.Add(this.toggleButtonSuperstore);
            this.Controls.Add(this.settingsPageSaveButton);
            this.Controls.Add(this.settingsPageNotificationCheckbox);
            this.Controls.Add(this.settingsPageNotificationLabel);
            this.Controls.Add(this.settingsPageTitleLabel);
            this.Controls.Add(this.searchPageSearchButton);
            this.Controls.Add(this.searchPageSearchBox);
            this.Controls.Add(this.mainPageLogoBox);
            this.Controls.Add(this.pageTitleTextBox);
            this.Controls.Add(this.mainPageSearchButton);
            this.Controls.Add(this.mainPageSearchBox);
            this.Controls.Add(this.navBar);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private Toggle toggleButtonSuperstore;
        private Toggle toggleButtonWalmart;
        private Toggle toggleButtonTnT;
        private Toggle toggleButtonSaveOnFoods;
        private Label labelToggleInstructions;
        private Label labelForSuperstoreToggle;
        private Label labelForWalmartToggle;
        private Label labelForTnTToggle;
        private Label labelForSaveOnFoodsToggle;
        private Label settingsPageTitleLabel;
        private Label settingsPageNotificationLabel;
        private CheckBox settingsPageNotificationCheckbox;
        private Button settingsPageSaveButton;
        private Label savedItemsListLabel;
        private Button savedItemsListPageRefreshButton;
        private SettingsPage settingsPage;
    }
}