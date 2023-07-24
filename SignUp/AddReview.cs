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
    public partial class AddReview : Form
    {
        private Users Customer;
        public AddReview(Users CurrentUser)
        {
            this.Customer = CurrentUser;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(this.Customer is Customer c)
            {
                string review = Review.Text;
                DialogResult r = MessageBox.Show("Add Review", "Are u sure u want to add this review", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    c.SetReview(review);
                }
            }
        }
    }
}
