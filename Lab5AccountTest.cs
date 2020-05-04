using System;

namespace Activity3TaniaTorresLab5
{
    class AccountTest
    {

        public static void Main()
        {

            double principle;
            double rate;
            double time;
            string choice = "1";


            while (choice != "-1")

            {
                Console.Write("Please enter the initial balance of your account : \n");
                principle = Convert.ToDouble(Console.ReadLine());


                Console.Write("Please enter the annual interest rate :\n");
                rate = Convert.ToDouble(Console.ReadLine());


                Console.Write("How many years will you accrue interest? \n");
                time = Convert.ToDouble(Console.ReadLine());


                Account A = new Account(principle, rate, time);

                for (int i = 0; i < 12 * time; i++)
                {
                    principle += (principle * A.addMonthlyInterest());
                }

                Console.Write("Your balance after " + time + " years is $" + principle + "\n");
                Console.Write("Press any key to continue or -1 for exit......\n\n");

                choice = Console.ReadLine();
            }
        }
    }
}
