using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Customer: Users
    {
        private List<Appointment> AppointmentsList = new List<Appointment>();
        private string Review;
        public Customer(string UserName, string Password, string Role, string Name, string PhoneNumber) : base(UserName, Password, Role, Name, PhoneNumber)
        { }
        public Customer(string UserName, string Password) : base(UserName, Password)
        { }
        public Customer() : base()
        {
            this.AppointmentsList = new List<Appointment>();
        }
        public Customer(string UserName, string Password, string Role, string Name, string PhoneNumber, List<Appointment> appointments, string Review) : base(UserName, Password, Role, Name, PhoneNumber)
        {
            this.AppointmentsList = appointments;
            this.Review = Review;
        }
        public Customer(string UserName, string Password, string Role, string Name, string PhoneNumber, string Review) : base(UserName, Password, Role, Name, PhoneNumber)
        {
            this.Review = Review;
        }
        public Customer(string UserName, string Password, string Role, string Name, string PhoneNumber, bool nviewd, string Review) : base(UserName, Password, Role, Name, PhoneNumber)
        {
            this.Review = Review;
        }
        public string GetReview()
        {
            return Review;
        }
        public void SetReview(string Review)
        {
            this.Review = Review;
        }
        public void AddReview(String Review)
        {
            this.Review = Review;
        }
        public void AddAppointment(Appointment appointment)
        {
            AppointmentsList.Add(appointment);
        }
        public List<Appointment> GetAppointmentList()
        {
            return AppointmentsList;
        }

        public void CancelAppointment(Appointment a)
        {
            AppointmentsList.Remove(a);

        }
        public override string WriteToFile()
        {
            return base.WriteToFile() + "," + Review;
        }
    }
}
