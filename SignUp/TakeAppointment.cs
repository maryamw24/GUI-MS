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
    public partial class TakeAppointment : Form
    {
        private Users CurrentUser;
        private List<Appointment> AppointmentList = new List<Appointment>();
        private List<Services> AppointmentServices = new List<Services>();
        public TakeAppointment(Users CurrentUser)
        {
              
            this.CurrentUser = CurrentUser;
            InitializeComponent();
            Add_Another.Enabled = false;
            DataBind();

        }

        private void TakeAppointment_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DataBind()
        {
            List<string> services = new List<string>();
            services.Add("-Select Service-");
            foreach (Services s in ServicesDL.ServiceList)
            {
                services.Add(s.Name1);
            }
            ServicesBox.DataSource = null;
            ServicesBox.DataSource = services;
            ServicesBox.Refresh();
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ServicesDL.ServiceList.Count+1;i++)
            {
                if (i == 0)
                {
                    if (ServicesBox.SelectedIndex == i)
                    {
                        MessageBox.Show("Please Select a service.");
                    }
                }
                else
                {
                    if (ServicesBox.SelectedIndex == i)
                    {
                        AppointmentServices.Add(ServicesDL.ServiceList[i - 1]);
                        Add_Another.Enabled = true;

                    }
                }

                
            }
        }
        private void Add_Another_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Date = dateSelect.Text;
            Appointment a = new Appointment(AppointmentServices, Date);
            a.BillCalculate();
            Bills.Text = a.Bill1.ToString();
            if (CurrentUser is Customer c) c.AddAppointment(a);
            UsersDL.WriteAppointments();
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
