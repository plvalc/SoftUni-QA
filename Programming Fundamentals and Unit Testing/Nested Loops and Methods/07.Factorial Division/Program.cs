static double CalculateFactiorial(int num)
{
    double result = 1;

    for (int i = 0; i < num; i++)
    {
        result *= (num - i);
    }
    return result;
}

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateFactiorial(n1) / CalculateFactiorial(n2));

//Console.WriteLine(CalculateFactiorial(n1));
//Console.WriteLine(CalculateFactiorial(n2));