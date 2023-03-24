using SaveYourGroceriesLib;
using System;
using System.Configuration;
using System.Windows.Forms;

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

            settingsPageNotificationCheckbox.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["notificationCheckboxStatus"]);
            settingsPageHourTextBox.Text = Convert.ToString(ConfigurationManager.AppSettings["notificationFrequencyHours"]);
            
            state = settingsPageNotificationCheckbox.CheckState;
            DisplaySetFrequencyControlsIfChecked();
        }

        private void OnCheckStatusChanged(object sender, EventArgs e)
        {
            state = settingsPageNotificationCheckbox.CheckState;
            DisplaySetFrequencyControlsIfChecked();
        }

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

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            PriceNotification notification = new PriceNotification();

            if (state == CheckState.Checked)
            {
                int notificationFrequencyHours = GetFrequencyHour();

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

        private int GetFrequencyHour()
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(settingsPageHourTextBox.Text);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
