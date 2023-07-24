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
    public partial class DeleteService : Form
    {
        public DeleteService()
        {
            InitializeComponent();
            DataBind(ServicesDL.ServiceList);
        }
        public void DataBind(List<Services> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            SizeSet();
            dataGridView1.Refresh();
        }
        public void RemoveColumn()
        {
            dataGridView1.Columns["Edit"].Visible = false;
        }
        private void SizeSet()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private int GetService(int number)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            string name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            return ServicesDL.GetIndex(name);

        }
       
        private void DeleteService_Load(object sender, EventArgs e)
        {
            DataBind(ServicesDL.ServiceList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            List<Services> s = ServicesDL.SearchServices(name);
            DataBind(s);

        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 0) {

                EditService s = new EditService(GetService(1));
                s.Show();
                DataBind(ServicesDL.ServiceList);

            }
            

        }

      
    }
}
