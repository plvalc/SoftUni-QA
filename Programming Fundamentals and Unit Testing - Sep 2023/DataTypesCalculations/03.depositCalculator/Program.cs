namespace _03.depositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double total = deposit + months * (deposit * interest / 100) / 12;
            Console.WriteLine(total);
        }
    }
}