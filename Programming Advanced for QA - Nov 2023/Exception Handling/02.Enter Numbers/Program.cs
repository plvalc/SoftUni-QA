using System;

namespace _02.Enter_Numbers
{
    internal class Program
    {
        static int ReadNumber(int start, int end)
        {
            int num = 1;
            num = int.Parse(Console.ReadLine());
            if (num <= start || num >= end)
                    throw new ArgumentException();

                return num;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new();
            int numbersCount = 0;
            int prevNum = 1;
            while(numbersCount < 10)
            {
                try
                {

                    int num = ReadNumber(prevNum, 100);
                    numbers.Add(num);
                    prevNum = num;
                    numbersCount++;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Your number is not in range {prevNum} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}