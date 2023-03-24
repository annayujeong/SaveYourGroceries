using SaveYourGroceriesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Notification notification = new Notification();
            string checkBoxStatus = string.Empty;

            if (state == CheckState.Checked)
            {
                checkBoxStatus = "true";
                GetFrequencyHour();
            }
            else
            {
                checkBoxStatus = "false";
            }

            notification.UpdateNotificationStatus(checkBoxStatus);

            config.AppSettings.Settings["notificationCheckboxStatus"].Value = checkBoxStatus;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private double GetFrequencyHour()
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(settingsPageHourTextBox.Text);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
