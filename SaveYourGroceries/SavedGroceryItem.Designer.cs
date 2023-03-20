namespace SaveYourGroceries
{
    partial class SavedGroceryItem
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
            this.savedItemListRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonReadJson = new System.Windows.Forms.Button();
            this.buttonWriteJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savedItemListRichTextBox
            // 
            this.savedItemListRichTextBox.Location = new System.Drawing.Point(93, 259);
            this.savedItemListRichTextBox.Name = "savedItemListRichTextBox";
            this.savedItemListRichTextBox.Size = new System.Drawing.Size(350, 519);
            this.savedItemListRichTextBox.TabIndex = 0;
            this.savedItemListRichTextBox.Text = "";
            // 
            // buttonReadJson
            // 
            this.buttonReadJson.Location = new System.Drawing.Point(54, 141);
            this.buttonReadJson.Name = "buttonReadJson";
            this.buttonReadJson.Size = new System.Drawing.Size(220, 54);
            this.buttonReadJson.TabIndex = 1;
            this.buttonReadJson.Text = "Read Json File";
            this.buttonReadJson.UseVisualStyleBackColor = true;
            this.buttonReadJson.Click += new System.EventHandler(this.buttonReadJSONFile_OnClick);
            // 
            // buttonWriteJson
            // 
            this.buttonWriteJson.Location = new System.Drawing.Point(304, 141);
            this.buttonWriteJson.Name = "buttonWriteJson";
            this.buttonWriteJson.Size = new System.Drawing.Size(220, 54);
            this.buttonWriteJson.TabIndex = 2;
            this.buttonWriteJson.Text = "Write Json File";
            this.buttonWriteJson.UseVisualStyleBackColor = true;
            this.buttonWriteJson.Click += new System.EventHandler(this.buttonWriteJSON_Click);
            // 
            // SavedGroceryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 1131);
            this.Controls.Add(this.buttonWriteJson);
            this.Controls.Add(this.buttonReadJson);
            this.Controls.Add(this.savedItemListRichTextBox);
            this.Name = "SavedGroceryItem";
            this.Text = "SavedGroceryItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox savedItemListRichTextBox;
        private System.Windows.Forms.Button buttonReadJson;
        private System.Windows.Forms.Button buttonWriteJson;
    }
}