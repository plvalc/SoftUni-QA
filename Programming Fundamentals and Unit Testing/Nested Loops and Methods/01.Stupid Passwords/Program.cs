int num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i += 2)
{
    for (int j = 1; j <= num; j+= 2)
    {
        Console.Write($"{i}{j}{i*j} ");
    }
}