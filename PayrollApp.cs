using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Application
{

    public class PayrollApp
    {
        
        public static void Main(string[] args)
        {
            Payroll pay = new Payroll();
            Console.WriteLine("First time running? ");
            string input = Console.ReadLine();

            if (input.ToLower().Equals("yes"))
            {
                pay.createEmployee();
                
            }
            else
            {
                pay.loadEmployee();
            }
            pay.selectEmployee();
        }  
     }
}
