static int CalculateFactorial(int n)
{
    int factorial = 1;
    for (int i = n; i > 0; i--)
    {
        factorial *= i;
    }
    return factorial;
}

int num = int.Parse(Console.ReadLine());

int sum = 0;

while (num > 0)
{
    int current = num % 10;
    num = num / 10;

    if (current % 2 == 0)
        sum += CalculateFactorial(current);
}
Console.WriteLine(sum);