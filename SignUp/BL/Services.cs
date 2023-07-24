using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Services
    {
        private string Name;
        private int Charges;
        private string Type;
        private string Discription;

        public string Name1 { get => Name; set => Name = value; }
        public int Charges1 { get => Charges; set => Charges = value; }
        public string Discription1 { get => Discription; set => Discription = value; }
        public string Type1 { get => Type; set => Type = value; }

        public Services(string Name, int Charges, string Type, string Discription)
        {
            this.Name1 = Name;
            this.Charges1 = Charges;
            this.Type1 = Type;
            this.Discription1 = Discription;
        }
        public string GetName()
        {
            return Name1;
        }
        public int GetCharges()
        {
            return Charges1;
        }
        public string getType()
        {
            return Type1;
        }
        public string GetDiscription()
        {
            return Discription1;
        }
        public void SetName(string Name)
        {
            this.Name1 = Name;
        }
        public void SetType(string Type)
        {
            this.Type    = Type;
        }
        public void SetCharges(int Charges)
        {
            this.Charges1 = Charges;
        }
        public void SetDiscription(string Discription)
        {
            this.Discription1 = Discription;
        }
        public void ViewServices()
        {
            Console.WriteLine(Name1.PadRight(20) + Type1.PadRight(20) + Charges1.ToString().PadRight(20) + Discription1.PadLeft(20));
        }
        public string WriteToFile()
        {
            return this.Name1 + "," + this.Charges1.ToString() + "," + this.Type1 + "," + this.Discription1;
        }
        public string GetAddNotification()
        {
            return " A new Service " + this.Name1 + "is being added in the service list of Salon.";
        }
        public string GetUpdatePriceNotification()
        {
            return " The Price of Service " + this.Name1 + "is being updated in the service list of Salon.";
        }
        public string GetDeletedNotification()
        {
            return " The Service " + this.Name1 + "is being remoed from the service list of Salon.";
        }
    }
}
