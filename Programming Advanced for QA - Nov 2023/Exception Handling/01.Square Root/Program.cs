namespace _01.Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            try
            {
                if (n < 0)
                {
                    throw new Exception();
                }
                else
                {
                    double sqrt = Math.Sqrt(n);
                    Console.WriteLine(sqrt);
                }
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }
    }
}