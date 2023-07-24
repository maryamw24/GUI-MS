using SignUp.DL;
using SignUp.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class EditService : Form
    {
        List<string> options = new List<String>
            {
                "---Select the type---","Hair","Skin","Makeup"
            };
        private int index;
        public EditService(int index)
        {
            this.index = index; 
            InitializeComponent();
            Services s = ServicesDL.ServiceList[index];
            S_Name.Text = s.GetName();
            S_Charges.Text = s.GetCharges().ToString();
            this.Discription.Text = s.GetDiscription();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Services Service = ServicesDL.ServiceList[index];
            string name = S_Name.Text;
            int charges = int.Parse(S_Charges.Text);
            string Discription = this.Discription.Text;
            DialogResult r = MessageBox.Show("Update Service", "Are u sure u want to upate the service", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Service.SetName(name);
                Service.SetCharges(charges);
                Service.SetDiscription(Discription);
                ServicesDL.WriteToFile();
                S_Name.Text = null;
                S_Charges.Text = null;
                this.Discription.Text = null;
                this.Hide();
                DeleteService obj = (DeleteService)Application.OpenForms["DeleteService"];
                obj.DataBind(ServicesDL.ServiceList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Delete Service", "Are u sure u want to delete the service", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                ServicesDL.ServiceList.RemoveAt(index);
                ServicesDL.WriteToFile();
                this.Hide();
                DeleteService obj = (DeleteService)Application.OpenForms["DeleteService"];
                obj.DataBind(ServicesDL.ServiceList);
            }
        }
    }
}
