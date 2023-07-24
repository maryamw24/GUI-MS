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

namespace SignUp
{
    public partial class Account : Form
    {
        private Form ActiveForm;
        private Users CurrentUser;
        public Account(Users CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalInfo p = new PersonalInfo(CurrentUser);
            OpenChildForm2(p);
        }
        private void OpenChildForm2(Form childForm)
        {
            if (childForm == null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(CurrentUser);
            OpenChildForm2(c);
        }
    }
}
