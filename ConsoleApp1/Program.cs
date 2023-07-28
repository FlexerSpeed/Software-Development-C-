using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Enter the amount of money");
            // double amount = Convert.ToDouble(Console.ReadLine());
            // double[] denominations = { 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05 };
            // int[] counts = new int[denominations.Length];
            // for (int i = 0; i < denominations.Length; i++)
            //{
            //    counts[i] = (int)(amount / denominations[i]);
            //    amount %= denominations[i];
            //}
            //Console.WriteLine("Denominations:");
            //for (int i = 0; i < denominations.Length; i++)
            //{
            //    if (counts[i] > 0)
            //    {
            //        Console.WriteLine($"Total €{denominations[i]}s is {counts[i]}");
            //    }
            // } 

            const int TOTALEURO50 = 5000;
            const int TOTALEURO20 = 2000;
            const int TOTALEURO10 = 1000;
            const int TOTALEURO5 = 500;
            const int TOTALEURO2 = 200;
            const int TOTALEURO1 = 100;
            const int TOTALCENTS50 = 50;
            const int TOTALCENTS20 = 20;
            const int TOTALCENTS10 = 10;
            const int TOTALCENTS5 = 5;

            int totalCents, totalFifties, totalTwenties, totalTens, remainder = 0;

            double initialMoneyAmount = 125.25; //12525

            totalCents = (int)(initialMoneyAmount * 100); //12525

            totalFifties = totalCents / TOTALEURO50; //2
            remainder = totalCents % TOTALEURO50; //2525

            Console.WriteLine("Total fifty euro notes is "
                             + totalFifties + " help me please");
            Console.WriteLine("Current remainder is "
                             + remainder);


            totalTwenties = remainder / TOTALEURO20; //2
            remainder = totalCents % TOTALEURO20; //2525

            Console.WriteLine("Total Twenty euro notes is "
                             + totalTwenties + " help me please");
            Console.WriteLine("Current remainder is "
                             + remainder);

            Console.ReadKey();

            totalTens = remainder / TOTALEURO10; //2
            remainder = totalCents % TOTALEURO10; //2525

            Console.WriteLine("Total Ten euro notes is "
                             + totalTens + " help me please");
            Console.WriteLine("Current remainder is "
                             + remainder);

            Console.ReadKey();

        }
    }
}
