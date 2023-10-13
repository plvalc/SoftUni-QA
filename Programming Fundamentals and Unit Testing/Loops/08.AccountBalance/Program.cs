using System.Security.Principal;

string command = Console.ReadLine();
double income = 0;
double total = 0;

while (command != "End")
{
    income = double.Parse(command);
    if (income > 0)
    {
        total += income;
        Console.WriteLine($"Increase: {income:F2}");
    }
    else if (income < 0)
    {
        income = Math.Abs(income);
        total -= income;
        Console.WriteLine($"Decrease: {income:F2}");
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Balance: {total:F2}");