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
    public partial class OwnerMenu : Form
    {
        private Form ActiveForm;
        private Users CurrentUser;
        public OwnerMenu(Users CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, Panel p)
        {
            if (childForm == null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new AddService();
            OpenChildForm(f,panel2);
            /*Form another = new AddService();
            another.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form another = new ViewServices();
            OpenChildForm(another,panel2);
        }
        private void OwnerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form another = new DeleteService();
            OpenChildForm(another,panel2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Search another = new Search();
           OpenChildForm(another,panel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewAppointment another = new ViewAppointment();
            OpenChildForm(another,panel2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SeeCustomers c = new SeeCustomers();
            OpenChildForm(c,panel2);
        }

        

        private void review_btn_Click(object sender, EventArgs e)
        {
            SeeReviews Reviews = new SeeReviews();
            OpenChildForm(Reviews,panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalonInfo s = new SalonInfo(CurrentUser);
            OpenChildForm(s,panel2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Account a = new Account(CurrentUser);
            OpenChildForm(a,panel2);
        }
    }
}
