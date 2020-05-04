using System;
    class PowTest
    {
  
        static void Main()
        {

            //displaying header

            Console.WriteLine("Number          Power of Two");
            Console.WriteLine("============================");

            //loops 11 times

            for (int i = 0; i <= 10; i++)
            {

                //prints formatted output

                Console.WriteLine($"{i}                 {Pow(i)}");

            }

        }

        static long Pow(long number)
        {

            //base cases

            if (number == 1)
            {

                return 2;

            }

            //second base case

            else if (number == 0)
            {

                return 1;

            }

            else
            {

                //calling recursivly

                return 2 * Pow(number - 1);

            }

        }

    }

}


 