using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.BL
{
    public class Information
    {

        private string SalonName;
        private string O_Time;
        private string C_Time;
        private string adress;
        public Information(string SalonName, string O_Time, string C_Time, string adress)
        {
            this.SalonName = SalonName;
            this.O_Time = O_Time;
            this.C_Time = C_Time;
            this.adress = adress;
        }
        public Information()
        {

        }
        public string GetSalonName()
        {
            return SalonName;
        }
        public string GetAdress()
        {
            return adress;
        }
        public string GetOpening()
        {
            return O_Time;
        }
        public string GetClosing()
        {
            return C_Time;
        }
        public void SetSalonName(string SalonName)
        {
             this.SalonName = SalonName;
        }
        public void SetAdress(string adress)
        {
             this.adress = adress;
        }
        public void SetOpening(string o_time)
        {
             this.O_Time = o_time;
        }
        public void SetClosing(string c_time)
        {
             this.C_Time = c_time;
        }

    }
}

