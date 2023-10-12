namespace _04.mandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());

            int total = numberOfPages / pagesPerHour / daysToFinish;

            Console.WriteLine(total);
        }
    }
}