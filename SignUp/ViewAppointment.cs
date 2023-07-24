using System;
using SignUp.BL;
using SignUp.DL;
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
    public partial class ViewAppointment : Form
    {
        public ViewAppointment()
        {

            InitializeComponent();
            DataBind();
            SetButton();
            SizeSet();

        }
        private void SetButton()
        {
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.Name = "services";
            select.HeaderText = "Services";
            select.Text = "Service";
            select.UseColumnTextForButtonValue = true;
            select.DefaultCellStyle.BackColor = Color.White;
            dG.Columns.Add(select);
        }
        private void SizeSet()
        {
            for (int i = 0; i < dG.Columns.Count; i++)
            {
                dG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ViewAppointment_Load(object sender, EventArgs e)
        {

        }
        private void DataBind()
        {
            dG.DataSource = null;
            List<Tuple<string, int, string>> x = new List<Tuple<string, int, string>>();
            foreach (Users u in UsersDL.UsersList)
            {
                if (u is Customer c)
                {
                    foreach (Appointment a in c.GetAppointmentList())
                    {
                        Tuple<string, int, string> B = new Tuple<string, int, string>(c.Name1, a.Bill1, a.Date);
                        x.Add(B);
                    }


                }
            }
            dG.DataSource = x;
            dG.Columns[0].HeaderText = "Name";
            dG.Columns[1].HeaderText = "Bill";
            dG.Columns[2].HeaderText = "Date";
            dG.Refresh();
        }

        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("These are the services for appointments \n\n" + ServicesReturn(), "Appointment Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string ServicesReturn()
        {
            int index = dG.SelectedCells[0].RowIndex;
            string name = dG.Rows[index].Cells[1].Value.ToString();
            Users u = UsersDL.GetUser(name);
            string s = "";
            if (u is Customer c)
            {
                foreach (Appointment a in c.GetAppointmentList())
                {
                    if(a.Date == dG.Rows[index].Cells[3].Value.ToString())
                    {
                        foreach(Services ser in a.Appointment_Services)
                        {
                            s += "-"+ser.Name1 + "\n";
                        }
                    }
                }
            }
            return s;

        }
    }
}
