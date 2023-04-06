using SaveYourGroceriesLib;
using System;
using System.Configuration;
using System.Windows.Forms;

/// <summary>
/// Author: Anna
/// Contain configuration for app settings page and its functionality.
/// </summary>
namespace SaveYourGroceries
{
    public partial class SettingsPage : UserControl
    {
        private CheckState state;
        public CheckState State
        {
            get { return state; }
            set { state = value; }
        }

        public SettingsPage()
        {
            InitializeComponent();

            // Set checkbox state and textbox as the user saved from app settings (or default if the user never have saved)
            settingsPageNotificationCheckbox.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["notificationCheckboxStatus"]);
            settingsPageHourTextBox.Text = Convert.ToString(ConfigurationManager.AppSettings["notificationFrequencyHours"]);
            
            state = settingsPageNotificationCheckbox.CheckState;
            DisplaySetFrequencyControlsIfChecked();
        }

        /// <summary>
        /// Update state on checkbox status change.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void OnCheckStatusChanged(object sender, EventArgs e)
        {
            state = settingsPageNotificationCheckbox.CheckState;
            DisplaySetFrequencyControlsIfChecked();
        }

        /// <summary>
        /// Display setting frequency controls if the settings notification checkbox is checked, otherwise hide.
        /// </summary>
        private void DisplaySetFrequencyControlsIfChecked()
        {
            if (state == CheckState.Checked)
            {
                settingsPageHourTextBox.Show();
                settingsPageNotificationLabel.Show();
            }
            else
            {
                settingsPageNotificationLabel.Hide();
                settingsPageHourTextBox.Hide();
            }
        }

        /// <summary>
        /// Handle settings save button click event.
        /// Save current states for notification checkbox and the hour textbox depending on the user input.
        /// Start pushing notification if the checkbox is checked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            PriceNotification notification = new PriceNotification();

            if (state == CheckState.Checked)
            {
                int notificationFrequencyHours;
                try
                {
                    notificationFrequencyHours = GetFrequencyHour();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                config.AppSettings.Settings["notificationCheckboxStatus"].Value = "true";
                config.AppSettings.Settings["notificationFrequencyHours"].Value = Convert.ToString(notificationFrequencyHours);

                notification.PushNotificationOnFrequencySet(notificationFrequencyHours);
            }
            else
            {
                config.AppSettings.Settings["notificationCheckboxStatus"].Value = "false";
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Get the notification frequency hour (user input) from the hour textbox.
        /// Throw exception if the input is not an int.
        /// </summary>
        /// <returns>frequency in int</returns>
        private int GetFrequencyHour()
        {
            return Convert.ToInt32(settingsPageHourTextBox.Text);
        }
    }
}
