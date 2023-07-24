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
    public partial class AddService : Form
    {
        List<string> options = new List<String>
            {
                "---Select the type---","Hair","Skin","Makeup"
            };
        public AddService()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServiceAdd_Load(object sender, EventArgs e)
        {
            DataBind(options);
        }
        private void DataBind(List<String> options)
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = options;
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type ="";
            for (int i = 1; i < options.Count; i++)
            { 
                if(comboBox1.SelectedIndex == i)
                {
                    type = options[i];
                }
            }
            string name = S_Name.Text;
            int charges = int.Parse(S_Charges.Text);
            string Discription = this.Discription.Text;
            DialogResult r = MessageBox.Show("Add Service","Are u sure u want to add the service",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Services s = new Services(name, charges, type, Discription);
                ServicesDL.AddService(s);
                ServicesDL.WriteToFile();
                S_Name.Text = null;
                S_Charges.Text = null;
                this.Discription.Text = null;
                comboBox1.Text = null;
            }
            else
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
