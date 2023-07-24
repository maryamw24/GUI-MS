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
    public partial class SeeReviews : Form
    {
        public SeeReviews()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            dG.DataSource = null;
            List<Users> u = UsersDL.GetCustomers();
            List<Tuple<string, string>> x = new List<Tuple<string, string>>();
            foreach (Users i in u)
            {
                if (i is Customer c)
                {
                    Tuple<string, string> t = new Tuple<string, string>(c.Name1, c.GetReview());
                    x.Add(t);
                }
            }
            dG.DataSource = x;
            SizeSet();
            dG.Columns[0].HeaderText = "Name";
            dG.Columns[1].HeaderText = "Review";
            dG.Refresh();
        }
        private void SizeSet()
        {
            for (int i = 0; i < dG.Columns.Count; i++)
            {
                dG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
