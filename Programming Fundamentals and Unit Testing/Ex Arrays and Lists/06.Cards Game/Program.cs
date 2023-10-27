List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

while (firstPlayer.Count > 0 &&  secondPlayer.Count > 0)
{
    int firstNum = firstPlayer[0];
    int secondNum = secondPlayer[0];

    if (firstNum > secondNum)
    {
        firstPlayer.Add(firstNum);
        firstPlayer.Add(secondNum);
    }
    else if(secondNum > firstNum)
    {
        secondPlayer.Add(secondNum);
        secondPlayer.Add(firstNum);
    }

    firstPlayer.RemoveAt(0);
    secondPlayer.RemoveAt(0);
}

if (firstPlayer.Count > 0)
{
    int sum = firstPlayer.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else if(secondPlayer.Count > 0)
{
    int sum = secondPlayer.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}