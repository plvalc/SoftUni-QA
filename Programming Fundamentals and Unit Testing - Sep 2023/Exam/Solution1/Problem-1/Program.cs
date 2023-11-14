int n = int.Parse(Console.ReadLine());
double gradeSum = 0;

for (int i = 0; i < n; i++)
{
    gradeSum += double.Parse(Console.ReadLine());
}
gradeSum /= n;

Console.WriteLine($"{gradeSum:F2}");