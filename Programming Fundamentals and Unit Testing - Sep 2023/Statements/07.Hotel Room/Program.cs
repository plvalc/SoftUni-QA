using System.Diagnostics;

namespace _07.Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month) 
            {
                case "May":
                case "October":
                    {
                        studioPrice = 50.0;
                        apartmentPrice = 65.0;

                        if (nights > 14)
                            studioPrice *= 0.7;
                        else if (nights > 7)
                            studioPrice *= 0.9;
                        break;
                    }

                case "June":
                case "September":
                    {
                        studioPrice = 75.2;
                        apartmentPrice = 68.7;

                        if (nights > 14)
                            studioPrice *= 0.8;
                        break;
                    }

                case "July":
                case "August":
                    {
                        studioPrice = 76.0;
                        apartmentPrice = 77.0;
                        break;
                    }
            }

            if (nights > 14)
                apartmentPrice *= 0.9;

            studioPrice *= nights;
            apartmentPrice *= nights;

            Console.WriteLine($" Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($" Studio: {studioPrice:f2} lv.");


        }
    }
}