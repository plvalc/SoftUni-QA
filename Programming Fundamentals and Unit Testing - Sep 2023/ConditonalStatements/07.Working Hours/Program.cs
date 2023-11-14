int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

bool isOpen = false;

if (hour >= 10 && hour < 18)
{
    if (day == "Monday" ||
        day == "Tuesday" ||
        day == "Wednesday" ||
        day == "Thursday" ||
        day == "Friday" ||
        day == "Saturday")
    {
        isOpen = true;
    }
}

if (isOpen)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}