using System.Configuration;
using System;

namespace SaveYourGroceries
{
    partial class SettingsPage
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
            this.settingsTitleLabel = new System.Windows.Forms.Label();
            this.settingsPageNotificationCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsPageSaveButton = new System.Windows.Forms.Button();
            this.settingsPageNotificationLabel = new System.Windows.Forms.Label();
            this.settingsPageHourTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // settingsTitleLabel
            // 
            this.settingsTitleLabel.AutoSize = true;
            this.settingsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsTitleLabel.Location = new System.Drawing.Point(10, 12);
            this.settingsTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.settingsTitleLabel.Name = "settingsTitleLabel";
            this.settingsTitleLabel.Size = new System.Drawing.Size(68, 20);
            this.settingsTitleLabel.TabIndex = 0;
            this.settingsTitleLabel.Text = "Settings";
            // 
            // settingsPageNotificationCheckbox
            // 
            this.settingsPageNotificationCheckbox.AutoSize = true;
            this.settingsPageNotificationCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsPageNotificationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPageNotificationCheckbox.Location = new System.Drawing.Point(21, 59);
            this.settingsPageNotificationCheckbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.settingsPageNotificationCheckbox.Name = "settingsPageNotificationCheckbox";
            this.settingsPageNotificationCheckbox.Size = new System.Drawing.Size(301, 22);
            this.settingsPageNotificationCheckbox.TabIndex = 11;
            this.settingsPageNotificationCheckbox.Text = "Get push notification on finding lower price";
            this.settingsPageNotificationCheckbox.UseVisualStyleBackColor = true;
            this.settingsPageNotificationCheckbox.CheckStateChanged += new System.EventHandler(this.OnCheckStatusChanged);
            // 
            // settingsPageSaveButton
            // 
            this.settingsPageSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.settingsPageSaveButton.FlatAppearance.BorderSize = 0;
            this.settingsPageSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsPageSaveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.settingsPageSaveButton.Location = new System.Drawing.Point(260, 158);
            this.settingsPageSaveButton.Name = "settingsPageSaveButton";
            this.settingsPageSaveButton.Size = new System.Drawing.Size(53, 31);
            this.settingsPageSaveButton.TabIndex = 12;
            this.settingsPageSaveButton.Text = "Save";
            this.settingsPageSaveButton.UseVisualStyleBackColor = false;
            this.settingsPageSaveButton.Click += new System.EventHandler(this.OnSaveButtonClicked);
            // 
            // settingsPageNotificationLabel
            // 
            this.settingsPageNotificationLabel.AutoSize = true;
            this.settingsPageNotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.settingsPageNotificationLabel.Location = new System.Drawing.Point(52, 92);
            this.settingsPageNotificationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.settingsPageNotificationLabel.Name = "settingsPageNotificationLabel";
            this.settingsPageNotificationLabel.Size = new System.Drawing.Size(225, 16);
            this.settingsPageNotificationLabel.TabIndex = 14;
            this.settingsPageNotificationLabel.Text = "Get Notification Every                  Hours";
            // 
            // settingsPageHourTextBox
            // 
            this.settingsPageHourTextBox.Location = new System.Drawing.Point(192, 91);
            this.settingsPageHourTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.settingsPageHourTextBox.Name = "settingsPageHourTextBox";
            this.settingsPageHourTextBox.Size = new System.Drawing.Size(34, 20);
            this.settingsPageHourTextBox.TabIndex = 15;
            this.settingsPageHourTextBox.Text = "2";
            this.settingsPageHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsPageHourTextBox);
            this.Controls.Add(this.settingsPageNotificationLabel);
            this.Controls.Add(this.settingsPageSaveButton);
            this.Controls.Add(this.settingsPageNotificationCheckbox);
            this.Controls.Add(this.settingsTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(332, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsTitleLabel;
        private System.Windows.Forms.CheckBox settingsPageNotificationCheckbox;
        private System.Windows.Forms.Button settingsPageSaveButton;
        private System.Windows.Forms.Label settingsPageNotificationLabel;
        private System.Windows.Forms.TextBox settingsPageHourTextBox;
    }
}
