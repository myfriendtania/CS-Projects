using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPayTaniaTorres
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //declare variables
                decimal grossPay = 0.0m;
                decimal fedTax = 0.0m;
                decimal netPay = 0.0m;
                int myHours = 0;
                decimal payRate = 0.0m;

                // Prompt the user for their hours and pay rate
                Console.WriteLine("Please enter the number of hours you worked: ");
                myHours = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your hourly pay rate: ");
                payRate = decimal.Parse(Console.ReadLine());

                // perform the calculation
                grossPay = myHours * payRate;
                fedTax = grossPay * 0.15m;
                netPay = grossPay - fedTax;

                Console.WriteLine(netPay = grossPay - payRate);
                Console.ReadLine();

                // Output
                Console.WriteLine($"Gross Pay \t{grossPay:C}");
                Console.WriteLine($"Fed Tax \t{fedTax:C}");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Net Pay \t{netPay:C}");
            
                
                //end
            }
        }

        }
    }
