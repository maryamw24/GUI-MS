using SignUp.BL;
using SignUp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class SignUp : Form
    {
        private System.Windows.Forms.ErrorProvider errorProvider;
        public SignUp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
       

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string UserName = this.UserName.Text;
            string Password = this.Password.Text;
            string Name = this.Name.Text;
            string Role = this.Role.Text;
            string PhoneNumber = this.PhoneNumber.Text;
            Users u = new Users(UserName, Password,Role,Name,PhoneNumber);
            bool isValid = UsersDL.IsValid(u);
            if (isValid)
            {
                if (u.GetRole() == "Customer" || u.GetRole() == "customer")
                {
                    Customer c = new Customer(u.GetUserName(), u.GetPassword(), u.GetRole(), u.GetName(), u.GetPhoneNumber());
                    UsersDL.AddUserToList(c);
                    UsersDL.WriteToFile();
                    MessageBox.Show("Sign Up Success!!");
                }
                else if (u.GetRole() == "Owner" || u.GetRole() == "owner")
                {
                    Owner o = new Owner(u.GetUserName(), u.GetPassword(), u.GetRole(), u.GetName(), u.GetPhoneNumber());
                    UsersDL.AddUserToList(o);
                    UsersDL.WriteToFile();
                    MessageBox.Show("Sign Up Success!!");
                }
            }
            else
            {
                MessageBox.Show("Unable to SignUpn!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form another = new Form2();
            this.Hide();
            another.Show();
        }
    }
}
