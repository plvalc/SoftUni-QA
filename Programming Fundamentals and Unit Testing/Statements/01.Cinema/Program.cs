using System.Data;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double totalPrice = 0;

            switch(type)
            {
                case "Premiere": totalPrice = seats * 12.00; break;
                case "Normal": totalPrice = seats * 7.5; break;
                case "Discount": totalPrice = seats * 5.0; break;
            }

            Console.WriteLine($"{totalPrice:F2} leva");


        }
    }
}