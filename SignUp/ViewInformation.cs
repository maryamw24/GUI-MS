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
    public partial class ViewInformation : Form
    {
        public ViewInformation()
        {
            InitializeComponent();
            if(UsersDL.GetOwner() is Owner o )
            {
                SalonName.Text = o.GetSalonInformation().GetSalonName();
                Adress.Text = o.GetSalonInformation().GetAdress();
                textBox1.Text = o.GetSalonInformation().GetOpening() + "am to " + o.GetSalonInformation().GetClosing() + " am";
            }
        }
        

        private void ViewInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
