using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            String season = Console.ReadLine();

            String destination = "";
            String holidayType = "";
            double amountSpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    amountSpent = budget * 0.3;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    amountSpent = budget * 0.7;
                    holidayType = "Hotel";
                }

            }

            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    amountSpent = budget * 0.4;
                    holidayType = "Camp";
                }

                else if (season == "winter")
                {
                    amountSpent = budget * 0.8;
                    holidayType = "Hotel";
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                amountSpent = budget * 0.9;
                holidayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:F2}");

            //· First line -"Somewhere in {destination}" among "Bulgaria", "Balkans" and "Europe"
            //· Second line -"{holidayType} - {amountSpent}"
            //    o Holidays can be between "Camp" and "Hotel"
            //    o The amount must be rounded to the second decimal place.
        }
    }
}