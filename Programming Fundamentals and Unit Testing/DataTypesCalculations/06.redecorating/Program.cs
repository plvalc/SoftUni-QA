namespace _06.redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonAmount = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int craftsmenHours = int.Parse(Console.ReadLine());

            double nylonCost = (nylonAmount + 2) * 1.5;
            double paintCost = paintLiters * 1.1 * 14.5;
            double thinnerCost = thinnerLiters * 5.0;
            double totalMaterialsCost = nylonCost + paintCost + thinnerCost + 0.4;
            double craftsmenHourCost = totalMaterialsCost * 0.3;

            double totalCost = totalMaterialsCost + craftsmenHourCost * craftsmenHours;
            Console.WriteLine(totalCost);


        }
    }
}