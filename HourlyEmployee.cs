using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Application
{

    [Serializable()]

    public class HourlyEmployee : Employee
    {
        private float hours;
        private float rate;
        public float overtime;
        public float overtimeHours;
        public float overtimeRate;
        //private float gross;

        private HourlyEmployee()  { }

        public HourlyEmployee(float gross, float taxrate, float tax, float net, float net_percent,
            float hours, float rate, float overtime, string emptype)
            : base(gross, taxrate, tax, net, net_percent, emptype) { }

        //public int Hours
        //{
        //    get
        //    {
        //        return hours;
        //    }
        //    set
        //    {
        //        string hrsInput = null;
        //        int input = 0;
        //        Console.Write("Hours: ");

        //        hrsInput = Console.ReadLine();
        //        input = Convert.ToInt32(hrsInput);
        //        hours = input;
        //    }

        //}

        //public float Rate
        //{
        //    get
        //    {
        //        return rate;
        //    }
        //    set
        //    {
        //        string rtInput = null;
        //        int input = 0;
        //        Console.Write("Rate: ");

        //        rtInput = Console.ReadLine();
        //        input = Convert.ToInt32(rtInput);
        //        rate = input;
        //    }
        //}

        //public float Overtime
        //{
        //    get
        //    {
        //        return overtime;
        //    }
        //    set
        //    {
        //        if (hours > 40)
        //        {
        //            overtimeHours = hours - 40;
        //            overtimeRate = rate * 1.5f;
        //            overtime = overtimeRate * overtimeHours;
        //        }
        //        else
        //        {
        //            overtime = 0;
        //        }

        //    }

        //}

        public override float computeGross()
        {
            Console.WriteLine("\n*Hourly Employee*");          
            //string hrsInput = null;
            float input = 0;
            Console.Write("\nHours: ");

            //input = Convert.ToInt32(hrsInput);
            input = float.Parse(Console.ReadLine());      
            hours = input;

            //string rtInput = null;
            float inputx = 0;
            Console.Write("Rate: ");

            //rtInput = Console.ReadLine();
            inputx = float.Parse(Console.ReadLine());
            rate = inputx;

            if (hours > 40)
            {
                overtimeHours = hours - 40;
                overtimeRate = rate * 1.5f;
                overtime = overtimeRate * overtimeHours;
            }
            else
            {
                overtime = 0;
            }

            gross = (rate * hours) + overtime;
            return gross;
        }

        public override string employeeType()
        {
            String emptype = "Hourly Employee";
            return emptype;
        }


    }
}
