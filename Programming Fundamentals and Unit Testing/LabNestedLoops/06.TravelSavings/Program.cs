string destination = Console.ReadLine();

double collected = 0.0;

while (destination != "End")
{
    double sum = 0.0;
    double neededBudget = double.Parse(Console.ReadLine());
    while (sum < neededBudget)
    {
        collected = double.Parse(Console.ReadLine());
        sum += collected;
        Console.WriteLine($"Collected: {sum:F2}");
        if (sum >= neededBudget)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }
    }
    destination = Console.ReadLine();
}
