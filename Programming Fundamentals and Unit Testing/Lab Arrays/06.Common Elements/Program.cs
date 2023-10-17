int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

foreach (int i in firstArray)
{
    foreach (int j in secondArray)
    {
        if (i == j)
        {
            Console.Write(i + " ");
        }
    }
}