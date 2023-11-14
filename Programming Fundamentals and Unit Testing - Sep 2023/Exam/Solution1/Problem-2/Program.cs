int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = int.Parse(Console.ReadLine());
//int[] tempString = new int[numbers.Length];

for ( int i = 0; i < count; i++)
{
    int tempNum = numbers[numbers.Length - 1];
    for ( int j = numbers.Length - 1; j > 0; j--)
    {
        numbers[j] = numbers[j - 1];
    }
    numbers[0] = tempNum;
}
Console.WriteLine(string.Join(", ", numbers));