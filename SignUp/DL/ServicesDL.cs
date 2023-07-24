using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUp.BL;
using System.IO;

namespace SignUp.DL
{
    public class ServicesDL
    {
        public static List<Services> ServiceList = new List<Services>();
        public static void AddService(Services s)
        {
            ServiceList.Add(s);
        }
        public static void UpdateName(string name, int index)
        {
            ServiceList[index].SetName(name);
        }
        public static void UpdatePrice(int charges, int index)
        {
            ServiceList[index].SetCharges(charges);
        }
        public static void UpdateDiscription(string discription, int index)
        {
            ServiceList[index].SetDiscription(discription);
        }
        public static void RemoveService(int i)
        {
            ServiceList.RemoveAt(i);    
        }

        public static int GetIndex(String Name)
        {
            for (int i = 0; i < ServiceList.Count; i++)
            {
                if (Name == ServiceList[i].GetName())
                {
                    return i;
                }
            }
            return -1;
        }
        public static Services GetService(string Name)
        {
            foreach(Services s in ServiceList)
            {
                if(s.GetName() == Name)
                {
                    return s;
                }
            }
            return null;
        }
        public static List<Services> SearchServices(string s)
        {
            List<Services> services = ServiceList.FindAll(item => item.GetName().StartsWith(s));
            return services;
        }

        public static bool ReadFromFile()
        {
            string path = "Services.txt";
            if (File.Exists(path))
            {
                ServiceList.Clear();
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    string Name = data[0];
                    int Charges = int.Parse(data[1]);
                    string Type = data[2];
                    string Description = data[3];
                    Services s = new Services(Name, Charges, Type, Description);
                    AddService(s);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void WriteToFile()
        {
            string path = "Services.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Services x in ServiceList)
            {
                file.WriteLine(x.WriteToFile());
            }
            file.Flush();
            file.Close();
        }
    }
}
