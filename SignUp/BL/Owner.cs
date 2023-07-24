using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Owner : Users
    {

        private Information SalonInformation;
        public Owner(string UserName, string Password, string Role, string Name, string PhoneNumber) : base(UserName, Password, Role, Name, PhoneNumber)
        { }
        public Owner(string UserName, string Password, string Role, string Name, string PhoneNumber, bool nviewd) : base(UserName, Password, Role, Name, PhoneNumber)
        { }
        public Owner(string UserName, string Password, string Role, string Name, string PhoneNumber, Information i) : base(UserName, Password, Role, Name, PhoneNumber)
        {
            this.SalonInformation = i;
        }
        public Owner(string UserName, string Password) : base(UserName, Password)
        { }
        public Owner() : base()
        {
        }

        public Information GetSalonInformation()
        {
            return SalonInformation;
        }
        public void SetSalonInformation(Information i)
        {
            this.SalonInformation = i;
        }

        public override string WriteToFile()
        {
            return base.WriteToFile();
        }
    }
}

