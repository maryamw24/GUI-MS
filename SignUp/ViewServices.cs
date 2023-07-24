using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignUp.DL;

namespace SignUp
{
    public partial class ViewServices : Form
    {
        public ViewServices()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            ServiceView.DataSource = null;
            ServiceView.DataSource = ServicesDL.ServiceList;
            SizeSet();
            ServiceView.Refresh();
        }
        private void SizeSet()
        {
            for(int i=0;i<ServiceView.Columns.Count;i++)
            {
                ServiceView.Columns[i].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewServices_Load(object sender, EventArgs e)
        {

        }

        private void ServiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
