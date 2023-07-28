using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static decimal v;

        static void Main(string[] args)
        {
            // SOLUTION 1
            Console.WriteLine("Enter the amount of money");
            v = Convert.ToDecimal(Console.ReadLine());
            var amount = v;
            decimal[] denominations = { 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.2m, 0.1m, 0.05m };
            int[] counts = new int[denominations.Length];
            for (int i = 0; i < denominations.Length; i++)
            {
                counts[i] = (int)(amount / denominations[i]);
                amount %= denominations[i];
            }
            Console.WriteLine("Denominations:");
            for (int i = 0; i < denominations.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"Total €{denominations[i]}s is {counts[i]}");
                }
            }
            Console.ReadKey();

            // SOLUTION 2

            /* const int TOTALEURO50 = 5000;
            const int TOTALEURO20 = 2000;
            const int TOTALEURO10 = 1000;
            const int TOTALEURO5 = 500;
            const int TOTALEURO2 = 200;
            const int TOTALEURO1 = 100;
            const int TOTALCENTS50 = 50;
            const int TOTALCENTS20 = 20;
            const int TOTALCENTS10 = 10;
            const int TOTALCENTS5 = 5;

            int totalCents, totalFifties, totalTwenties, totalTens,
                totalFives, totalTwos, totalOnes, totalFiftiesC,
                totalTwentiesC, totalTensC, totalFivesC, remainder = 0;

            double initialMoneyAmount = 125.25;
            totalCents = (int)(initialMoneyAmount * 100);

            totalFifties = totalCents / TOTALEURO50;
            remainder = totalCents % TOTALEURO50;

            Console.WriteLine("Total fifty euro notes is " + totalFifties);
            Console.WriteLine("Current remainder is " + remainder);



            totalTwenties = remainder / TOTALEURO20;
            remainder = remainder % TOTALEURO20;

            Console.WriteLine("Total Twenty euro notes is " + totalTwenties);
            Console.WriteLine("Current remainder is " + remainder);



            totalTens = remainder / TOTALEURO10;
            remainder = remainder % TOTALEURO10;

            Console.WriteLine("Total Ten euro notes is " + totalTens);
            Console.WriteLine("Current remainder is " + remainder);



            totalFives = remainder / TOTALEURO5;
            remainder = remainder % TOTALEURO5;

            Console.WriteLine("Total Five euro notes is " + totalFives);
            Console.WriteLine("Current remainder is " + remainder);



            totalTwos = remainder / TOTALEURO2;
            remainder = remainder % TOTALEURO2;

            Console.WriteLine("Total Two euro notes is " + totalTwos);
            Console.WriteLine("Current remainder is " + remainder);



            totalOnes = remainder / TOTALEURO1;
            remainder = remainder % TOTALEURO1;

            Console.WriteLine("Total One euro notes is " + totalOnes);
            Console.WriteLine("Current remainder is " + remainder);



            totalFiftiesC = remainder / TOTALCENTS50;
            remainder = remainder % TOTALCENTS50;

            Console.WriteLine("Total fifty cents notes is " + totalFiftiesC);
            Console.WriteLine("Current remainder is " + remainder);



            totalTwentiesC = remainder / TOTALCENTS20;
            remainder = remainder % TOTALCENTS20;

            Console.WriteLine("Total twenty cents notes is " + totalTwentiesC);
            Console.WriteLine("Current remainder is " + remainder);



            totalTensC = remainder / TOTALCENTS10;
            remainder = remainder % TOTALCENTS10;

            Console.WriteLine("Total ten cents notes is " + totalTensC);
            Console.WriteLine("Current remainder is " + remainder);



            totalFivesC = remainder / TOTALCENTS5;
            remainder = remainder % TOTALCENTS5;

            Console.WriteLine("Total five cents notes is " + totalFivesC);
            Console.WriteLine("Current remainder is " + remainder);

            Console.ReadKey(); */

        }
    }
}
