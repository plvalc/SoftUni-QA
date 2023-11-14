int floor = int.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());
string type = "L";

for (int i = floor; i >= 1; i--)
{
    if (i < floor)
    {
        if (i % 2 == 0)
            type = "O";
        else
            type = "A";
    }

    for (int j = 0; j < number; j++)
    {
        Console.Write($"{type}{i}{j} ");
    }
        Console.WriteLine();
}
