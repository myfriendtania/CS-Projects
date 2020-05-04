using System;

namespace LabFiveTaniaTorres
{

    class Account

    {
        private double principle;
        private double rate;
        private double time;

        public Account(double principle, double rate, double time)
        {


            this.principle = principle;
            this.rate = rate;
            this.time = time;
        }
        public double addMonthlyInterest()
        {
            return (rate / 100) / 12;
        }
    }
}

