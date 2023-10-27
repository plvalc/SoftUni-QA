List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bombList = Console.ReadLine().Split().Select(int.Parse).ToList();

int bomb = bombList[0];
int pow = bombList[1];

for (int i = 0; i < numbers.Count; i++)
{
    int currentNum = numbers[i];
    if (currentNum == bomb)
    {
        int startIndex = i - pow;
        int removeCount = pow * 2 + 1;
        if (startIndex < 0)
        {
            removeCount += startIndex;
            startIndex = 0;
        }
        if (removeCount + startIndex > numbers.Count)
        {
            removeCount = numbers.Count - startIndex;
        }
        numbers.RemoveRange(startIndex, removeCount);
        i = startIndex - 1;
    }
}
//Console.WriteLine(string.Join(" ", numbers));

Console.WriteLine(numbers.Sum());
