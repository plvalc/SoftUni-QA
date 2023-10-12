namespace _04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            String season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double rentPrice = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring": rentPrice = 3000; break;
                case "Summer":
                case "Autumn": rentPrice = 4200; break;
                case "Winter": rentPrice = 2600; break;
            }

            if (people <= 6)
                discount = 0.9;
            else if (people <= 11)
                discount = 0.85;
            else if (people >= 12)
                discount = 0.75;

            rentPrice *= discount;

            if (people % 2 == 0 && season != "Autumn")
                rentPrice *= 0.95;

            if (budget - rentPrice >= 0)
                Console.WriteLine($"Yes! You have {(budget - rentPrice):F2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {(rentPrice - budget):F2} leva.");


        }
    }
}