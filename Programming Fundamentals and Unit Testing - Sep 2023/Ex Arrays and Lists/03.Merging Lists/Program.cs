List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

int longerList = 0;

if(firstList.Count > secondList.Count)
    longerList = firstList.Count;
else
    longerList= secondList.Count;

for (int i = 0; i < longerList; i++)
{
    if(firstList.Count > i)
        result.Add(firstList[i]);

    if(secondList.Count > i)
        result.Add(secondList[i]);
}
Console.WriteLine(string.Join(" ", result));