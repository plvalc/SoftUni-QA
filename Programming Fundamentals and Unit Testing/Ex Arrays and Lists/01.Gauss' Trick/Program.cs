int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] results = new int[numbers.Length / 2 + numbers.Length % 2];

for (int i = 0; i < (numbers.Length / 2); i++)
{
    int firstNum = numbers[i];
    int secondNum = numbers[numbers.Length - (1 + i)];
    results[i] = firstNum + secondNum;
}

if (numbers.Length  % 2 == 1)
{
    int lastIndex = numbers.Length / 2;
    int lastNum = numbers[lastIndex];
    results[lastIndex] = lastNum;
}

foreach (int n in results)
    Console.Write($"{n} ");