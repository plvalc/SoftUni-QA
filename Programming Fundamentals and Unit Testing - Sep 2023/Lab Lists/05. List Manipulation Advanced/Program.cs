using System.Globalization;

List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        //int numToCheck = int.Parse(command.Split()[1]);
        if (nums.Contains(int.Parse(command.Split(" ")[1])))
            Console.WriteLine("Yes");
        else 
            Console.WriteLine("No such number");
    }
    else if (command.StartsWith("PrintEven"))
    {
        List<int> newList = nums.ToList();
        newList.RemoveAll(num => num % 2 != 0);
        Console.WriteLine(string.Join(" ", newList));
        //Console.WriteLine(string.Join(" ", nums.RemoveAll(num => num % 2 != 0)));
    }
    else if (command.StartsWith("PrintOdd"))
    {
        List<int> newList = nums.ToList();
        newList.RemoveAll(num => num % 2 == 0);
        Console.WriteLine(string.Join(" ", newList));
        //Console.WriteLine(string.Join(" ", nums.RemoveAll(num => num % 2 == 0)));
    }
    else if (command.StartsWith("GetSum"))
    {
        int sum = 0;
        foreach (int n in nums)
            sum += n;
        Console.WriteLine(sum);
    }
    else if (command.StartsWith("Filter"))
    {
        List<int> newList = nums.ToList();
        string condition = command.Split(" ")[1];
        int n = int.Parse(command.Split(" ")[2]);
        if (condition == "<")
        {
            newList.RemoveAll(num => num >= n);
            Console.WriteLine(string.Join(" ", newList));
        }
        if (condition == ">")
        {
            newList.RemoveAll(num => num <= n);
            Console.WriteLine(string.Join(" ", newList));
        }
        if (condition == "<=")
        {
            newList.RemoveAll(num => num > n);
            Console.WriteLine(string.Join(" ", newList));
        }
        if (condition == ">=")
        {
            newList.RemoveAll(num => num < n);
            Console.WriteLine(string.Join(" ", newList));
        }
    }
            command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", nums));