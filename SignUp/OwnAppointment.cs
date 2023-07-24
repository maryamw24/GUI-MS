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
using SignUp.BL;

namespace SignUp
{
    public partial class OwnAppointment : Form
    {
        private Users CurrentCustomer;
        public OwnAppointment(Users CurrentCustomer)
        {
            this.CurrentCustomer = CurrentCustomer;
            InitializeComponent();
            DataBind();
            SetButton("Services");
            SetButton("Cancel");
            SizeSet();
        }
        private void SetButton(string s)
        {
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.Name = s;
            select.HeaderText = s;
            select.Text = s;
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
        private void DataBind()
        {
            dG.DataSource = null;
            List<Tuple<int, string>> x = new List<Tuple<int, string>>();
            if (CurrentCustomer is Customer c)
                foreach (Appointment a in c.GetAppointmentList())
                {
                    Tuple<int, string> B = new Tuple<int, string>(a.Bill1, a.Date);
                    x.Add(B);
                }



            dG.DataSource = x;

            dG.Columns[0].HeaderText = "Bill";
            dG.Columns[1].HeaderText = "Date";
            dG.Refresh();
        }

        private void dG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("These are the services for appointments \n\n" + ServicesReturn(), "Appointment Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult r = MessageBox.Show("Cancel Appointment", "Are u sure u want to cancel the appointment", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (CurrentCustomer is Customer c) c.CancelAppointment(Cancel());
                    dG.Refresh();
                }
            }UsersDL.WriteAppointments();

            
        }
        private Appointment Cancel()
        {
            if (CurrentCustomer is Customer C)
            {
                int index = dG.SelectedCells[0].RowIndex;
                foreach (Appointment a in C.GetAppointmentList())
                {
                    if (a.Date == dG.Rows[index].Cells[3].Value.ToString())
                    {
                        return a;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        return null;
            
        }
        private string ServicesReturn()
        {
            int index = dG.SelectedCells[0].RowIndex;
            string s = "";
            if (CurrentCustomer is Customer c)
            {
                foreach (Appointment a in c.GetAppointmentList())
                {
                    if (a.Date == dG.Rows[index].Cells[3].Value.ToString())
                    {
                        foreach (Services ser in a.Appointment_Services)
                        {
                            s += "-" + ser.Name1 + "\n";
                        }
                    }
                }
            }
            return s;

        }
    }
}
