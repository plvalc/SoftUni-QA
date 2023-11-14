using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace _05.teachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pensPackages = int.Parse(Console.ReadLine());
            int markersPackages = int.Parse(Console.ReadLine());
            int CleanerLiters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //•	Package of pens - 5.80 lv.
            //•	Package of markers - 7.20 lv.
            //•	Board cleaner -1.20 BGN(per liter)

            double priceOfPens = pensPackages * 5.8;
            double priceOfMarkers = markersPackages * 7.2;
            double priceOfCleaner= CleanerLiters * 1.2;

            double total = priceOfPens + priceOfMarkers + priceOfCleaner;
            total = total * (100 - discount) / 100;

            Console.WriteLine(total);
            

        }
    }
}