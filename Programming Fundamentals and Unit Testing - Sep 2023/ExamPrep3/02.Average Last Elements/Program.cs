int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

double sum = 0;
int index = numbers.Length  - n;

for (int i = index; i < numbers.Length; i++)
{
    sum += numbers[i];
}
sum /= n;
Console.WriteLine($"{sum:f2}");

