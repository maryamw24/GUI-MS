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
    public partial class PersonalInfo : Form
    {
        private Users CurrentUser;
        public PersonalInfo(Users CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            u_name.Text = CurrentUser.Name1;
            UName.Text = CurrentUser.UserName1;
            maskedTextBox1.Text = CurrentUser.PhoneNumber1;
            u_name.Enabled = false;
            UName.Enabled = false;
            maskedTextBox1.Enabled = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string UserName = this.UserName.Text;
            string Name = this.Name.Text;
            string PhoneNumber = maskedTextBox1.Text;
           DialogResult r = MessageBox.Show("Change information", "Are u sure u want to change information?", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                CurrentUser.SetUserName(UserName);
                CurrentUser.SetName(Name);
                CurrentUser.SetPhoneNumber(PhoneNumber);
                UsersDL.WriteToFile();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UName.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            u_name.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void SalonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {


        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }
    }
}
