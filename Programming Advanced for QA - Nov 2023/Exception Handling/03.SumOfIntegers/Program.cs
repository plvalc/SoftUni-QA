using System.Xml.Linq;

namespace _03.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] allElements = input.Split();
            int sumOfIntegers = 0;
            int currentNum = 0;
            string currentElement = "";

            for (int i = 0; i < allElements.Length; i++)
            {
                try
                {
                    currentElement = allElements[i];
                    currentNum = int.Parse(currentElement);
                    sumOfIntegers += currentNum;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{currentElement}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{currentElement}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{currentElement}' processed - current sum: {sumOfIntegers}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sumOfIntegers}");
        }
    }
}
