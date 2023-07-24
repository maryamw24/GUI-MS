using SignUp.DL;
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
    public partial class Search : Form
    {
        public List<Services> s;
        public Search()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s;
            SizeSet();
            dataGridView1.Refresh();
        }
        private void SizeSet()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            s = ServicesDL.SearchServices(name);
            dataGridView1.DataSource = s;
            dataGridView1.Refresh();
        }
    }
}
