int n = int.Parse(Console.ReadLine());

double percent2 = 0;
double percent3 = 0;
double percent4 = 0;


for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum % 2 == 0)
        percent2 += 1;
    if (currentNum % 3 == 0)
        percent3 += 1;
    if (currentNum % 4 == 0)
        percent4 += 1;
}

percent2 = percent2 / n * 100.0;
percent3 = percent3 / n * 100.0;
percent4 = percent4 / n * 100.0;

Console.WriteLine($"{percent2:F2}%");
Console.WriteLine($"{percent3:F2}%");
Console.WriteLine($"{percent4:F2}%");