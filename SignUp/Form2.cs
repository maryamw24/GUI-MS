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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UsersDL.ReadFromFile();
           bool done = ServicesDL.ReadFromFile();
            UsersDL.ReadAppointments();
            UsersDL.ReadInformationToFile();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            Users u = new Users(UserName, Password);
            Users CurrentUser = UsersDL.SignIn(u);
            

                if (CurrentUser is Customer)
                {
                    Customer currentUser = (Customer)CurrentUser;
                    Form another = new CustomerMenu(currentUser);
                    another.Show();
                    this.Hide();
                }
                if (CurrentUser is Owner)
                {
                    Owner o = (Owner)CurrentUser;
                    Form another = new OwnerMenu(o);
                    another.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Canoot sign in");
                }
            
            
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            Form moreForm = new SignUp();
            this.Hide();
            moreForm.Show();
        }

    
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
