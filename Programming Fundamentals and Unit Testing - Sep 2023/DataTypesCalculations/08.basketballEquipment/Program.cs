namespace _08.basketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakersPrice = annualFee * 0.6;
            double teamPrice = sneakersPrice * 0.8;
            double ballPrice = teamPrice * 0.25;
            double accPrice = ballPrice * 0.2;

            double total = annualFee + sneakersPrice + teamPrice + ballPrice + accPrice;

            Console.WriteLine(total);
        }
    }
}