List<int> firstNums = new List<int>();
List<int> secondNums = new List<int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

    if(i % 2 == 0)
    {
        firstNums.Add(input[0]);
        secondNums.Add(input[1]);
    }
    else
    {
        firstNums.Add(input[1]);
        secondNums.Add(input[0]);
    }
}
Console.WriteLine(string.Join(" ", firstNums));
Console.WriteLine(string.Join(" ", secondNums));