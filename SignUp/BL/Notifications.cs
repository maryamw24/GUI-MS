using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Notifications
    {
        private string notifications;
        private bool status;
        public Notifications(string notifications, bool status)
        {
            this.notifications = notifications;
            this.status = status;
        }
        public Notifications(string notifications)
        {
            this.notifications = notifications;
            this.status = true;
        }
        public void SetNotification(string notification)
        {
            this.notifications = notification;
        }
        public string GetNotifiiication()
        {
            return this.notifications;
        }
        public void SetStatus(bool status)
        {
            this.status = status;
        }
        public bool GetStatus()
        {
            return this.status;
        }
        public string WriteToFile()
        {
            return this.notifications + "," + this.status;
        }
    }
}
