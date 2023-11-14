namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeLiters = volume / 1000;
            double waterLiters = volumeLiters * (1 - percent / 100);
            //waterLiters = Math.Round(waterLiters, 2);
            Console.WriteLine($"{waterLiters:F2}");
            //Console.WriteLine("{0:0.00}", waterLiters);
            //string result = waterLiters.ToString("0.00");
            //Console.WriteLine(result);
        }
    }
}