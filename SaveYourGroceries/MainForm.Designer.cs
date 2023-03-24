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
            this.mainPageSearchBox.Size = new System.Drawing.Size(250, 31);
            this.mainPageSearchBox.TabIndex = 1;
            // 
            // savedListMenu
            // 
            this.savedListMenu.ForeColor = System.Drawing.Color.White;
            this.savedListMenu.Name = "savedListMenu";
            this.savedListMenu.Size = new System.Drawing.Size(50, 46);
            this.savedListMenu.Text = "Saved";
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
            // 
            this.settingsPage.Location = new System.Drawing.Point(0, 1);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(332, 454);
            this.settingsPage.State = System.Windows.Forms.CheckState.Unchecked;
            this.settingsPage.TabIndex = 7;
            this.settingsPage.Hide();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(332, 506);
            this.Controls.Add(this.settingsPage);
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
        private SettingsPage settingsPage;
    }
}