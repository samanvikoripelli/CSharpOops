using System;
namespace CSharp1
{
    public class Bank
    {
        private static double InterestRate;
        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }
        public void ShowInterestRate()
        {
            Console.WriteLine("Current Interest Rate: " + InterestRate + "%");
        }
    }
}