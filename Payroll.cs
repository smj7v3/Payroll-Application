using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Payroll_Application
{

    [Serializable()]

    public class Payroll 
    {

      

        //[XmlArrayItem(Type = typeof(Employee)),
        //    XmlArrayItem(Type = typeof(HourlyEmployee)), XmlArrayItem(Type = typeof(SalaryEmployee)), XmlArrayItem(Type = typeof(CommissionEmployee))]

        Employee[] emp = new Employee[3];            //(float gross, float taxrate, float tax, float net, float net_percent, int hours, float rate, float overtime)
        HourlyEmployee HE = new HourlyEmployee(0, .2f, 0, 0, 0, 0, 0, 0, "Hourly Employee");
        SalaryEmployee SE = new SalaryEmployee(0, .2f, 0, 0, 0, 0, "Salary Employee");
        CommissionEmployee CE = new CommissionEmployee(0, .2f, 0, 0, 0, 0, 0, "Commission Employee");
        int i;

        //public void menu()
        //{



        //}       

        public void createEmployee()
        {
            for (int x = 0; x < emp.Length; x++)
            {
                if (x == 0)
                {
                    emp[x] = HE;        //0 is Hourly
                }
                if (x == 1)
                {
                    emp[x] = SE;        //1 is Salaried
                }
                if (x == 2)
                {
                    emp[x] = CE;        //2 is Commissioned
                }
            }

            Console.WriteLine("");

            selectEmployee();

        }


        public void selectEmployee()
        {        
            string sEinput = null;
            int input = 0;

            while (input != -1)
            {
                Console.WriteLine("\nPlease select an employee to edit: \n 0) Hourly Employee "
        + " \n 1) Salary Employee \n 2) Commission Employee \n 3) Exit)");
                Console.Write("\nSelection: ");

                //string[] resultArray = Array.ConvertAll(emp, x => x.ToString());
                //System.IO.File.WriteAllLines(@"C:\Users\Smj7v\test.txt", emp);
                //File.WriteAllLines(@"C:\Users\Smj7v\test.txt", emp.Cast<string>());
                sEinput = Console.ReadLine();
                input = Convert.ToInt32(sEinput);

                

                if (input == 0)
                {
                    i = input;
                    emp[i].menu();                 
                }
                if (input == 1)
                {
                    i = input;
                    emp[i].menu();
                }
                if (input == 2)
                {
                    i = input;
                    emp[i].menu();
                }
                if (input == 3)
                {
                    saveEmployee();
                    int code = 0;
                    Environment.Exit(code);
                }      
            }
        }


        public void saveEmployee()
        {
            Stream FileStream = File.Create("Employee.xml");
            XmlSerializer serializer = new XmlSerializer(emp.GetType());
            XmlSerializer seriously = new XmlSerializer(typeof(Employee[]));
            seriously.Serialize(FileStream, emp);
            FileStream.Close();
        }


        public void loadEmployee()
        {
            Stream Filestream = File.OpenRead("Employee.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Employee[]));
            emp = (Employee[])deserializer.Deserialize(Filestream);
            Filestream.Close();
        }

        //public void textEmployee()
        //{
        //    string[] resultArray = Array.ConvertAll(emp, x => x.ToString());
        //    System.IO.File.WriteAllLines(@"C:\Users\Smj7v\test.txt", emp);
        //    File.WriteAllLines(@"C:\Users\Smj7v\test.txt", emp.Cast<string>());
            
        //}
    }
}
