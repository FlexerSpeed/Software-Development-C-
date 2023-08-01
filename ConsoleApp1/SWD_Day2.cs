using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SWD_Day2
    {
        static void Main(string[] args)
        {

            const double discount = 0.95;
            const int threshold = 200;
            const int zoneNdCharge = 5;
            const int zoneSdCharge = 10;
            const string zoneSd = "SD";
            const string zoneNd = "ND";

            double noOfSqMetres, pricePerSqMetre, totalCerpetCost;
            bool existingCustomer;
            string deliveryZone;

            Console.WriteLine("Please enter number of square metres");
            noOfSqMetres = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter price per square metre");
            pricePerSqMetre = double.Parse(Console.ReadLine());

            Console.WriteLine("Are You existing customer?");
            existingCustomer = bool.Parse(Console.ReadLine());

            Console.WriteLine("Please enter delivery zone: SD or ND");
            deliveryZone = Console.ReadLine();


            totalCerpetCost = noOfSqMetres * pricePerSqMetre;

            if (existingCustomer) // fall trough if statment
            {
                totalCerpetCost = totalCerpetCost * discount;
            }


            if (totalCerpetCost < threshold && deliveryZone == zoneSd)
            {
                totalCerpetCost += zoneSdCharge;
            }
            else if (totalCerpetCost < threshold && deliveryZone == zoneNd)
            {
                totalCerpetCost += zoneNdCharge;
            }

            Console.WriteLine("Carpet cost is " + totalCerpetCost.ToString(""));

            Console.ReadKey();


        }

        




    }
}
