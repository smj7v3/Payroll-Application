using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Application
{

    [Serializable()]

    public class SalaryEmployee : Employee
    {
        //public float gross;
        public float weeklySalary;

        private SalaryEmployee() { }

        public SalaryEmployee(float gross, float taxrate, float tax, float net, float net_percent,
            float weeklySalary, string emptype) 
            : base(gross, taxrate, tax, net, net_percent, emptype) { }
       

        //public float WeeklySalary
        //{
        //    get
        //    {
        //        return weeklySalary;
        //    }
        //    set
        //    {
        //        string wsInput = null;
        //        int input = 0;
        //        Console.Write("Please select: \n1) Staff \n2) Executive ");

        //        wsInput = Console.ReadLine();
        //        input = Convert.ToInt32(wsInput);
        //        if (input == 1)
        //        {
        //            weeklySalary = 500000;
        //        }
        //        if (input == 2)
        //        {
        //            weeklySalary = 1000000;
        //        }
                
        //    }
        //}

        public override float computeGross()
        {
            Console.WriteLine("\n*Salary Employee*");
            Console.WriteLine("");

            string wsInput = null;
            int input = 0;
            Console.WriteLine("Please select: \n1) Staff \n2) Executive ");

            wsInput = Console.ReadLine();
            input = Convert.ToInt32(wsInput);
            if (input == 1)
            {
                weeklySalary = 500000;
            }
            if (input == 2)
            {
                weeklySalary = 1000000;
            }

            gross = weeklySalary;
            return gross;

        }

        public override string employeeType()
        {
            String emptype = "Salary Employee";
            return emptype;
        }
    }
}

