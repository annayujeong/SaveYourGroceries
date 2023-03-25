using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.PropertyGridInternal;

namespace SaveYourGroceriesLib
{
    public class Notification
    {

        // if we want to use SaveYourGroceriesLib Settings.settings instead of txt file
        // 1. Add new Settings item in SaveYourGroceriesLib
        // 2. Add notificationCheckboxStatus field
        // 3. Settings.Default.notificationCheckboxStatus = isOn;
        // 4. Settings.Default.Save();
        // 5. Settings.Default.Reload();
        public void UpdateNotificationStatus(bool isOn)
        {
            using (StreamWriter writer = new StreamWriter(Constants.NOTI_TXT_FILE_LOCATION))
            {
                writer.WriteLine(isOn);
            }
        }
    }
}
