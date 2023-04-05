using System.Windows.Forms;

namespace SaveYourGroceriesLib
{
    partial class SearchedItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.storeNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(24, 21);
            this.itemPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(293, 262);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 0;
            this.itemPictureBox.TabStop = false;
            // 
            // storeNameTextBox
            // 
            this.storeNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.storeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.storeNameTextBox.Location = new System.Drawing.Point(333, 21);
            this.storeNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.storeNameTextBox.Name = "storeNameTextBox";
            this.storeNameTextBox.Size = new System.Drawing.Size(384, 38);
            this.storeNameTextBox.TabIndex = 1;
            this.storeNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemNameTextBox.Location = new System.Drawing.Point(333, 105);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(384, 38);
            this.itemNameTextBox.TabIndex = 2;
            this.itemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.itemPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemPriceTextBox.Location = new System.Drawing.Point(413, 157);
            this.itemPriceTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(304, 38);
            this.itemPriceTextBox.TabIndex = 3;
            this.itemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemSaveButton
            // 
            this.itemSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.itemSaveButton.FlatAppearance.BorderSize = 0;
            this.itemSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemSaveButton.ForeColor = System.Drawing.Color.White;
            this.itemSaveButton.Location = new System.Drawing.Point(517, 229);
            this.itemSaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.itemSaveButton.Name = "itemSaveButton";
            this.itemSaveButton.Size = new System.Drawing.Size(200, 55);
            this.itemSaveButton.TabIndex = 4;
            this.itemSaveButton.Text = "Save";
            this.itemSaveButton.UseVisualStyleBackColor = false;
            this.itemSaveButton.Click += new System.EventHandler(this.saveItemToJSON);
            // 
            // SearchedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.itemSaveButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.storeNameTextBox);
            this.Controls.Add(this.itemPictureBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SearchedItem";
            this.Size = new System.Drawing.Size(747, 310);
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox itemPictureBox;
        public System.Windows.Forms.TextBox storeNameTextBox;
        public System.Windows.Forms.TextBox itemNameTextBox;
        public System.Windows.Forms.TextBox itemPriceTextBox;
        public System.Windows.Forms.Button itemSaveButton;
    }
}
