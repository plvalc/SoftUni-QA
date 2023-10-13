string command = Console.ReadLine();

while (command != "End")
{
    int number = int.Parse(command);
    int sum = 0;
    for (int i = number; i > 0; i /= 10)
    {
        int digit = i % 10;
        sum += digit;
    }

    Console.WriteLine($"Sum of digits = {sum}");
    command = Console.ReadLine();
}
Console.WriteLine("Goodbye");