using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Appointment
    {
        private List<Services> appointment_Services = new List<Services>();
        private string date;
        private int Bill;

        public List<Services> Appointment_Services { get => appointment_Services; set => appointment_Services = value; }
        public string Date { get => date; set => date = value; }
        public int Bill1 { get => Bill; set => Bill = value; }

        public string GetDate()
        {
            return Date;
        }
        public int GetBill()
        {
            return Bill1;
        }
        public Appointment(List<Services> appointment_Services, string date)
        {
            this.Appointment_Services = appointment_Services;
            this.Date = date;
        }
        public Appointment()
        { }
        public Appointment(List<Services> appointment_Services, string date, int Bill)
        {
            this.Appointment_Services = appointment_Services;
            this.Date = date;
            this.Bill1 = Bill;
        }
        public List<Services> GetServiceList()
        {
            return Appointment_Services;
        }
        public string WriteToFile()
        {
            string x = "";
            if(Appointment_Services.Count ==1)
            { x += Appointment_Services[Appointment_Services.Count - 1].GetName(); }
            if (Appointment_Services.Count > 1)
            {
                for (int i = 0; i < Appointment_Services.Count - 1; i++)
                {
                    x += Appointment_Services[i].GetName() + "-";
                }
                x += Appointment_Services[Appointment_Services.Count - 1].GetName();
            }
            x += "," + this.Date + "," + this.Bill1.ToString();
            return x;
        }

        public void BillCalculate()
        {
            Bill1 = 0;
            foreach (Services i in Appointment_Services)
            {
                Bill1 = Bill1 + i.GetCharges();
            }

        }
    }
}
