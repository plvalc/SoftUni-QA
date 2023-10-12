namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            · Type of flowers - text with options - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            · Flowers count - an integer in the range [10... 1000]
            · Budget - an integer in the range [50... 2500]
            */
            String type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            /*
                            Flower Roses Dahlias Tulips Narcissus Gladiolus
            Price per piece in BGN 5     3.80    2.80   3         2.50
            */
            switch (type)
            {
                case ("Roses"):
                    {
                        price = count * 5.00;
                        if (count > 80) price *= 0.9;
                        break;
                    }
                case ("Dahlias"):
                    {
                        price = count * 3.8;
                        if (count > 90) price *= 0.85;
                        break;
                    }
                case ("Tulips"):
                    {
                        price = count * 2.80;
                        if (count > 80) price *= 0.85;
                        break;
                    }
                case ("Narcissus"):
                    {
                        price = count * 3.00;
                        if (count < 120) price *= 1.15;
                        break;
                    }
                case ("Gladiolus"):
                    {
                        price = count * 2.50;
                        if (count < 80) price *= 1.2;
                        break;
                    }
            }
            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {(budget - price):F2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");
            
            //· If their budget is enough - "Hey, you have a great garden with {flowersCount} {flowersType} and {sumLeft} leva left."
            //· If their budget is NOT enough, "Not enough money, you need {neededMoney} leva more."

        

        }
    }
}