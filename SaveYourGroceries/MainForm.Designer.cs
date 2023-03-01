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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemPriceBox = new System.Windows.Forms.TextBox();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(16, 24);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(292, 48);
            this.searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(326, 24);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 44);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemNameBox
            // 
            this.itemNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameBox.Location = new System.Drawing.Point(21, 258);
            this.itemNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(218, 35);
            this.itemNameBox.TabIndex = 2;
            // 
            // itemPriceBox
            // 
            this.itemPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceBox.Location = new System.Drawing.Point(21, 314);
            this.itemPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemPriceBox.Name = "itemPriceBox";
            this.itemPriceBox.Size = new System.Drawing.Size(218, 35);
            this.itemPriceBox.TabIndex = 3;
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(21, 97);
            this.itemPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(285, 128);
            this.itemPictureBox.TabIndex = 4;
            this.itemPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(511, 376);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.itemPriceBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.TextBox itemPriceBox;
        private System.Windows.Forms.PictureBox itemPictureBox;
    }
}

