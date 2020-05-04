using System;

namespace Lab6_TaniaTorres
{
    class Fraction
    {
        private int whole;
        private int numerator;
        private int denominator;

        //Constructor
        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                Console.WriteLine("Zero in the denominator is invalid.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            numerator = num;
            denominator = den;
            whole = 0;


        }
        public void getParts(out int whole, out int num, out int den)
        {
            whole = this.whole;
            num = this.numerator;
            den = this.denominator;
        }
        public void simplify()
        {
            whole = numerator / denominator;
            numerator = numerator % denominator;
            int div = gcd(numerator, denominator);
            numerator /= div;
            denominator /= div;
        }
        public string getString()
        {
            if (whole == 0)
                return numerator + "/" + denominator;
            else if (numerator == 0)
                return whole.ToString();
            else if (whole == 0 && denominator == 1)
                return numerator.ToString();
            else
                return whole + " " + numerator + "/" + denominator;
        }
        private static int gcd(int x1, int y1)
        {
            if (y1 == 0)
                return x1;
            else
                return gcd(y1, x1 % y1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a numerator: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter a denominator: ");
            int den = int.Parse(Console.ReadLine());
           
            Fraction fraction = new Fraction(num, den);
           
            fraction.simplify();
            Console.WriteLine("In simplified from, that fraction is " + fraction.getString());

            int whole;
            fraction.getParts(out whole, out num, out den);
            num = (den * whole) + num;
            double value = (double)num / den;
            Console.WriteLine("The decimal value is {0}", value);
            //pause
            Console.ReadLine();
        }
    }
}
