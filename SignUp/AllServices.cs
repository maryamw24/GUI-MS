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
    public partial class AllServices : Form
    {
        public AllServices()
        {
            InitializeComponent();
            DataBind(ServicesDL.ServiceList);
        }
        private void DataBind(List<Services> List)
        {
            ServiceView.DataSource = null;
            ServiceView.DataSource = List;
            SizeSet();
            ServiceView.Refresh();
        }
        private void SizeSet()
        {
            for (int i = 0; i < ServiceView.Columns.Count; i++)
            {
                ServiceView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            List<Services> s = ServicesDL.SearchServices(name);
            DataBind(s);
        }
    }
}
