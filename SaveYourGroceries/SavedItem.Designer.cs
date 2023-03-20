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
            this.savedItemPictureBox = new System.Windows.Forms.PictureBox();
            this.savedStoreNameTextBox = new System.Windows.Forms.TextBox();
            this.savedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.savedItemPriceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.savedItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // savedItemPictureBox
            // 
            this.savedItemPictureBox.Location = new System.Drawing.Point(27, 21);
            this.savedItemPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemPictureBox.Name = "savedItemPictureBox";
            this.savedItemPictureBox.Size = new System.Drawing.Size(293, 262);
            this.savedItemPictureBox.TabIndex = 0;
            this.savedItemPictureBox.TabStop = false;
            // 
            // savedStoreNameTextBox
            // 
            this.savedStoreNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savedStoreNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedStoreNameTextBox.Location = new System.Drawing.Point(343, 31);
            this.savedStoreNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedStoreNameTextBox.Name = "savedStoreNameTextBox";
            this.savedStoreNameTextBox.Size = new System.Drawing.Size(384, 45);
            this.savedStoreNameTextBox.TabIndex = 1;
            this.savedStoreNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savedItemNameTextBox
            // 
            this.savedItemNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savedItemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedItemNameTextBox.Location = new System.Drawing.Point(343, 102);
            this.savedItemNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemNameTextBox.Name = "savedItemNameTextBox";
            this.savedItemNameTextBox.Size = new System.Drawing.Size(384, 45);
            this.savedItemNameTextBox.TabIndex = 2;
            this.savedItemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savedItemPriceTextBox
            // 
            this.savedItemPriceTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savedItemPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savedItemPriceTextBox.Location = new System.Drawing.Point(343, 190);
            this.savedItemPriceTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.savedItemPriceTextBox.Name = "savedItemPriceTextBox";
            this.savedItemPriceTextBox.Size = new System.Drawing.Size(384, 45);
            this.savedItemPriceTextBox.TabIndex = 3;
            this.savedItemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SavedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.savedItemPriceTextBox);
            this.Controls.Add(this.savedItemNameTextBox);
            this.Controls.Add(this.savedStoreNameTextBox);
            this.Controls.Add(this.savedItemPictureBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SavedItem";
            this.Size = new System.Drawing.Size(747, 310);
            ((System.ComponentModel.ISupportInitialize)(this.savedItemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox savedItemPriceTextBox;
        public System.Windows.Forms.TextBox savedStoreNameTextBox;
        public System.Windows.Forms.TextBox savedItemNameTextBox;
        public System.Windows.Forms.PictureBox savedItemPictureBox;
    }
}
