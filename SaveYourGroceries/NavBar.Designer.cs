namespace SaveYourGroceries
{
    partial class NavBar
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
            this.navSavedListButton = new System.Windows.Forms.Button();
            this.navSearchButton = new System.Windows.Forms.Button();
            this.navSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navSavedListButton
            // 
            this.navSavedListButton.Location = new System.Drawing.Point(0, 0);
            this.navSavedListButton.Name = "navSavedListButton";
            this.navSavedListButton.Size = new System.Drawing.Size(229, 109);
            this.navSavedListButton.TabIndex = 0;
            this.navSavedListButton.Text = "Saved";
            this.navSavedListButton.UseVisualStyleBackColor = true;
            // 
            // navSearchButton
            // 
            this.navSearchButton.Location = new System.Drawing.Point(226, 0);
            this.navSearchButton.Name = "navSearchButton";
            this.navSearchButton.Size = new System.Drawing.Size(239, 109);
            this.navSearchButton.TabIndex = 1;
            this.navSearchButton.Text = "Search";
            this.navSearchButton.UseVisualStyleBackColor = true;
            // 
            // navSettingsButton
            // 
            this.navSettingsButton.Location = new System.Drawing.Point(460, 0);
            this.navSettingsButton.Name = "navSettingsButton";
            this.navSettingsButton.Size = new System.Drawing.Size(229, 109);
            this.navSettingsButton.TabIndex = 2;
            this.navSettingsButton.Text = "Settings";
            this.navSettingsButton.UseVisualStyleBackColor = true;
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navSettingsButton);
            this.Controls.Add(this.navSearchButton);
            this.Controls.Add(this.navSavedListButton);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(689, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navSavedListButton;
        private System.Windows.Forms.Button navSearchButton;
        private System.Windows.Forms.Button navSettingsButton;
    }
}
