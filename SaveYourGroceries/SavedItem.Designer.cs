namespace SaveYourGroceries
{
    partial class SavedItem
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
            this.savedItemRemoveButton = new System.Windows.Forms.Button();
            this.savedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.savedItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.savedItemStoreTextBox = new System.Windows.Forms.TextBox();
            this.savedItemPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.savedItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // savedItemRemoveButton
            // 
            this.savedItemRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savedItemRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.savedItemRemoveButton.ForeColor = System.Drawing.Color.White;
            this.savedItemRemoveButton.Location = new System.Drawing.Point(490, 226);
            this.savedItemRemoveButton.Name = "savedItemRemoveButton";
            this.savedItemRemoveButton.Size = new System.Drawing.Size(204, 81);
            this.savedItemRemoveButton.TabIndex = 0;
            this.savedItemRemoveButton.Text = "Remove";
            this.savedItemRemoveButton.UseVisualStyleBackColor = false;
            this.savedItemRemoveButton.Click += new System.EventHandler(this.removeItemFromJSON);
            // 
            // savedItemNameTextBox
            // 
            this.savedItemNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savedItemNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.savedItemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedItemNameTextBox.Location = new System.Drawing.Point(335, 42);
            this.savedItemNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemNameTextBox.Name = "savedItemNameTextBox";
            this.savedItemNameTextBox.Size = new System.Drawing.Size(384, 38);
            this.savedItemNameTextBox.TabIndex = 7;
            this.savedItemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savedItemPriceTextBox
            // 
            this.savedItemPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savedItemPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.savedItemPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedItemPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedItemPriceTextBox.Location = new System.Drawing.Point(335, 107);
            this.savedItemPriceTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemPriceTextBox.Name = "savedItemPriceTextBox";
            this.savedItemPriceTextBox.Size = new System.Drawing.Size(384, 38);
            this.savedItemPriceTextBox.TabIndex = 8;
            this.savedItemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savedItemStoreTextBox
            // 
            this.savedItemStoreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savedItemStoreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.savedItemStoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savedItemStoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedItemStoreTextBox.Location = new System.Drawing.Point(335, 178);
            this.savedItemStoreTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemStoreTextBox.Name = "savedItemStoreTextBox";
            this.savedItemStoreTextBox.Size = new System.Drawing.Size(384, 38);
            this.savedItemStoreTextBox.TabIndex = 9;
            this.savedItemStoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savedItemPictureBox
            // 
            this.savedItemPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savedItemPictureBox.Location = new System.Drawing.Point(26, 19);
            this.savedItemPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemPictureBox.Name = "savedItemPictureBox";
            this.savedItemPictureBox.Size = new System.Drawing.Size(293, 262);
            this.savedItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.savedItemPictureBox.TabIndex = 10;
            this.savedItemPictureBox.TabStop = false;
            // 
            // SavedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.savedItemPictureBox);
            this.Controls.Add(this.savedItemStoreTextBox);
            this.Controls.Add(this.savedItemPriceTextBox);
            this.Controls.Add(this.savedItemNameTextBox);
            this.Controls.Add(this.savedItemRemoveButton);
            this.Name = "SavedItem";
            this.Size = new System.Drawing.Size(747, 310);
            ((System.ComponentModel.ISupportInitialize)(this.savedItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savedItemRemoveButton;
        public System.Windows.Forms.TextBox savedItemNameTextBox;
        public System.Windows.Forms.TextBox savedItemPriceTextBox;
        public System.Windows.Forms.TextBox savedItemStoreTextBox;
        public System.Windows.Forms.PictureBox savedItemPictureBox;
    }
}
