using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUp.BL;
using System.IO;

namespace SignUp.DL
{
    class UsersDL
    {
        public static List<Users> UsersList = new List<Users>();
        public static void AddUserToList(Users u)
        {
            UsersList.Add(u);
        }
        public static bool IsValid(Users info)
        {
            bool flag = true;
            for (int i = 0; i < UsersList.Count; i++)
            {
                if (info.GetUserName() == UsersList[i].GetUserName())
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static List<Users> GetCustomers()
        {
            List<Users> user = new List<Users>();
            foreach (Users u in UsersList)
            {
                if(u is Customer c)
                {
                    user.Add(c);
                }
            }
            return user;
        }
        public static Users GetOwner()
        {
            foreach (Users u in UsersList)
            {
                if (u is Owner)
                {
                    return u;
                }
            }
            return null ;
        }
        public static Users GetUser(string name)
        {
            foreach (Users x in UsersList)
            {
                if (name == x.GetName())
                {
                    return x;
                }
            }
            return null;
        }
        public static void ReadFromFile()
        {
            string path = "Users.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    if (data[2] == "owner" || data[2] == "Owner")
                    {
                        /*Information i = new Information(data[5], data[6], data[7]);*/
                        AddUserToList(new Owner(data[0], data[1], data[2], data[3], data[4],bool.Parse(data[5])));
                    }
                    else if (data[2] == "customer" || data[2] == "Customer")
                    {
                        AddUserToList(new Customer(data[0], data[1], data[2], data[3], data[4], bool.Parse(data[5]),data[6]));
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Data Loading Errors");
            }
        }
        public static Users SignIn(Users info)
        {
            foreach (Users i in UsersList)
            {
                if (info.GetUserName() == i.GetUserName() && info.GetPassword() == i.GetPassword())
                {
                    return i;
                }
            }
            return null;
        }


        public static void WriteToFile()
        {
            string path = "Users.txt";
            StreamWriter myFile = new StreamWriter(path);
            foreach (Users x in UsersList)
            {
                if (x is Customer)
                {
                    Customer c = (Customer)x;
                    myFile.WriteLine(c.WriteToFile());
                }
                else if (x is Owner)
                {
                    Owner o = (Owner)x;
                    myFile.WriteLine(o.WriteToFile());
                }
            }
            myFile.Flush();
            myFile.Close();
        }
        public static void WriteAppointments()
        {
            string path = "Appointments.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Users x in UsersList)
            {
                if (x is Customer y)
                {
                    foreach (BL.Appointment a in y.GetAppointmentList())
                    {
                        file.WriteLine(a.WriteToFile() + "," + y.GetName());
                    }
                }
            }
            file.Flush();
            file.Close();
        }
        public static void ReadAppointments()
        {
            string path = "Appointments.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                   
                    List<Services> ServiceList = new List<Services>();
                    string date;
                    int bill = 0;
                    string[] data = record.Split(',');
                    string[] services = data[0].Split('-');
                    for (int j = 0; j < services.Count(); j++)
                    {
                        Services s = ServicesDL.GetService(services[j]);
                        if (s != null)
                        {
                            ServiceList.Add(s);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    date = data[1];
                    bill = int.Parse(data[2]);
                    BL.Appointment a = new BL.Appointment(ServiceList, date, bill);
                    Users u = GetUser(data[data.Count() - 1]);
                    if (u is Customer x)
                    {
                        x.GetAppointmentList().Clear();
                        x.AddAppointment(a);
                    }
                }
                file.Close();
            }
        }
        public static void WriteNotificationsToFile()
        {
            string Path = "Notifications.txt";
            StreamWriter file = new StreamWriter(Path);
            foreach(Users i in UsersList)
            {
                foreach(Notifications n in i.GetNotificationsList())
                {
                    file.WriteLine(n.GetNotifiiication() + "," + n.GetStatus() + "," + i.GetUserName());
                }
            }
            file.Flush();
            file.Close();
        }
        public static void ReadNotificationsFornFile()
        {
            string path = "Notifications.txt";
            if (File.Exists(path))
            {
                StreamReader myfile = new StreamReader(path);
                string record;
                while((record = myfile.ReadLine() ) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    foreach (Users u in UsersList)
                    {
                        if (SplittedRecord[2] == u.GetUserName())
                        {
                            if (u is Owner o)
                            {
                                Notifications n = new Notifications(SplittedRecord[0], bool.Parse(SplittedRecord[1]));
                                o.AddNotifications(n);
                            }
                            else if (u is Customer c)
                            {
                                Notifications n = new Notifications(SplittedRecord[0], bool.Parse(SplittedRecord[1]));
                                c.AddNotifications(n);
                            }
                        }
                    }
                }
                myfile.Close();
            }
        }
        public static void AddInformationToFile()
        {
            string path = "Information.txt";
            StreamWriter myfile = new StreamWriter(path);
            foreach (Users i in UsersList)
            {
                if (i is Owner o)
                    myfile.WriteLine(o.GetSalonInformation().GetSalonName() + "," + o.GetSalonInformation().GetOpening() + "," + o.GetSalonInformation().GetClosing() + "," + o.GetSalonInformation().GetAdress());
            }
            myfile.Flush();
            myfile.Close();
        }
        public static void ReadInformationToFile()
        {
            string path = "Information.txt";
            if (File.Exists(path))
            {
                StreamReader myfile = new StreamReader(path);
                string record;
                while ((record = myfile.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    Information inf = new Information(SplittedRecord[0],SplittedRecord[1], SplittedRecord[2], SplittedRecord[3]);
                    foreach (Users i in UsersList)
                    {
                        if (i is Owner o)
                            o.SetSalonInformation(inf);
                    }
                }
                myfile.Close();
                
            }
        }
        /*public static int CountNotifications(Users u)
        {
            int count = 0;
            if (u is Owner owner && !owner.GetNotificationsStatus())
            {
                foreach (Users y in UsersList)
                {
                    if (y is Customer z)
                    {
                        foreach (Notifications i in z.GetNotificationsList())
                        {
                            if (i.GetStatus())
                            {
                                count++;
                            }
                        }
                    }
                }
            }*/
            /*else if (u is Customer customer && !customer.GetNotificationsStatus())
            {
                foreach (Users y in UsersList)
                {
                    if (y is Owner z)
                    {
                        foreach (Notifications i in z.GetNotificationsList())
                        {
                            if (i.GetStatus())
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }*/
        public static void CheckAppointment()
        {
            foreach (Users u in UsersList)
            {
                if (u is Customer c)
                {
                    foreach (BL.Appointment a in c.GetAppointmentList())
                    {
                        if (a.GetDate() == DateTime.Now.ToShortDateString())
                        {
                            string notification = "You have an appointment with " + c.GetName() + " today.";
                            Notifications n = new Notifications(notification);
                            c.AddNotifications(n);
                        }
                    }
                }
            }
        }

    }
}

