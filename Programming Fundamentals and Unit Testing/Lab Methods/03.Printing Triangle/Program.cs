static void PrintTriangle(int num)
{
    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
    for (int i = num - 1; i > 0; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
}
int n = int.Parse(Console.ReadLine());

    PrintTriangle(n);
