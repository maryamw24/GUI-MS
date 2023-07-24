using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignUp.BL;
using SignUp.DL;

namespace SignUp
{
    public partial class SalonInfo : Form
    {
        private Users Owner;
        public SalonInfo(Users Owner)
        {
            this.Owner = Owner;
            InitializeComponent();
            if(Owner is Owner o)
            {
                SalonName.Text = o.GetSalonInformation().GetSalonName();
                Adress.Text = o.GetSalonInformation().GetAdress();
                O_Time.Text = o.GetSalonInformation().GetOpening();
                C_Time.Text = o.GetSalonInformation().GetClosing();
                Adress.Enabled = false;
                SalonName.Enabled = false;
                O_Time.Enabled = false;
                C_Time.Enabled = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Salonname = SalonName.Text;
            string adress = Adress.Text;
            string o_time = O_Time.Text;
            string c_time = C_Time.Text;
            Information i = new Information(Salonname, o_time, c_time, adress);
            if (Owner is Owner o) o.SetSalonInformation(i);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SalonName.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Adress.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            O_Time.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            C_Time.Enabled= true;
        }
    }
}
