namespace _07.foodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegieMenus = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double vegiePrice = vegieMenus * 8.15;
            double menusPrice = chickenPrice + fishPrice + vegiePrice;
            double dessertPrice = menusPrice * 0.2;

            double total = menusPrice + dessertPrice + 2.5;
            Console.WriteLine(total);
        }
    }
}