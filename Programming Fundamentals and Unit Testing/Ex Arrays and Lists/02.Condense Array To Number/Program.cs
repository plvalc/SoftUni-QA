int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] result = new int[(numbers.Length - 1) * 2];
int indexClear = numbers.Length - 1;

while (indexClear >= 1)
{
    for (int i = 0; i < indexClear; i++)
    {
        result[2 * i] = numbers[i];
        result[2 * i + 1] = numbers[i + 1];
    }
    for (int i = 0; i < indexClear; i++)
    {
        numbers[i] = result[2 * i] + result[2 * i + 1];
    }
    numbers[indexClear] = 0;
    indexClear--;
}
Console.WriteLine(numbers[0]);