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
    public partial class ChangePassword : Form
    {
        private Users CurrentUser;
        public ChangePassword(Users CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string O_Password = this.O_Password.Text;
            if (O_Password == CurrentUser.Password1)
            {
                string N_Password = this.N_Password.Text;
                string C_Passord = this.C_Password.Text;
                if (N_Password == C_Passord)
                {
                    CurrentUser.SetPassword(N_Password);
                    UsersDL.WriteToFile();
                }
                else
                {
                    MessageBox.Show("Password doesnot match");
                }
            }
            else
            {
                MessageBox.Show("Enter the correct Password");
            }
        }
    }
}
