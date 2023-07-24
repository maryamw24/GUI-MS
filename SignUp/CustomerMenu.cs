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
    public partial class CustomerMenu : Form
    {
        private Users CurrentUser;
        private Form ActiveForm;
        public CustomerMenu(Users CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form another = new AllServices();
            OpenChildForm(another);
        }
        private void OpenChildForm(Form childForm)
        {
            if (childForm == null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel6.Controls.Add(childForm);
            panel6.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       /* private void OpenChildForm2(Form childForm)
        {
            if (childForm == null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel9.Controls.Add(childForm);
            panel9.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form another = new TakeAppointment(CurrentUser);
            OpenChildForm(another);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form another = new OwnAppointment(CurrentUser);
            OpenChildForm(another);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form another = new ViewInformation();
            OpenChildForm(another);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new AddReview(CurrentUser);
            OpenChildForm(f);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account a = new Account(CurrentUser);
            OpenChildForm(a);
        }
    }
}
