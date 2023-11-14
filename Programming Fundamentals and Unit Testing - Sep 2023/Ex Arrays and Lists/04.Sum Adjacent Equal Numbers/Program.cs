List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count - 1; i++)
{
    int firstNum = numbers[i];
    int secondNum = numbers[i + 1];
    if (firstNum == secondNum)
    {
        numbers[i] = firstNum + secondNum;
        numbers.RemoveAt(i + 1);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", numbers));
