using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
   public class Users
    {
        private string UserName;
        private string Password;
        private string Role;
        private string Name;
        private string PhoneNumber;
        private List<Notifications> NotificationsList;
        private bool nViewed;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Role1 { get => Role; set => Role = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }

        public Users(string UserName, string Password, string Role)
        {
            this.UserName1 = UserName;
            this.Password1 = Password;
            this.Role1 = Role;
        }
        public Users(){ }
        public Users(string UserName, string Password)
        {
            this.UserName1 = UserName;
            this.Password1 = Password;
        }
        public void SetUserName(string UserName)
        {
            this.UserName1 = UserName;
        }
        public string GetUserName()
        {
            return UserName1;
        }
        public void SetPassword(string Password)
        {
            this.Password1 = Password;
        }
        public string GetPassword()
        {
            return Password1 ;
        }
        public void SetRole(string Role)
        {
            this.Role1 = Role;
        }
        public string GetRole()
        {
            return Role1;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public void RemoveNotificaion()
        {
            NotificationsList.Clear();
        }
        public List<Notifications> GetNotificationsList()
        {
            return NotificationsList;
        }
        public void AddNotifications(Notifications n)
        {
            NotificationsList.Add(n);
        }
        public Users(string UserName, string Password, string Role, string Name, string PhoneNumber)
        {
            this.UserName1 = UserName;
            this.Password1 = Password;
            this.Role1 = Role;
            this.Name1 = Name;
            this.PhoneNumber1 = PhoneNumber;
            /*this.NotificationsList = new List<Notifications>();*/
            this.nViewed = false;
        }
        public virtual string WriteToFile()
        {
            return this.GetUserName() + "," + this.GetPassword() + "," + this.GetRole() + "," + this.GetName() + "," + this.GetPhoneNumber() + "," + this.nViewed;
        }
    }
}
