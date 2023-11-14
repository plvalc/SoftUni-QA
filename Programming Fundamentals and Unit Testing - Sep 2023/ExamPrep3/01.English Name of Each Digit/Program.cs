int num = int.Parse(Console.ReadLine());

while (num > 0)
{
    int currentDigit = num % 10;
    num /= 10;
    if(currentDigit == 1)
        Console.WriteLine("one");
    else if(currentDigit == 2)
        Console.WriteLine("two");
    else if (currentDigit == 3)
        Console.WriteLine("three");
    else if (currentDigit == 4)
        Console.WriteLine("four");
    else if (currentDigit == 5)
        Console.WriteLine("five");
    else if (currentDigit == 6)
        Console.WriteLine("six");
    else if (currentDigit == 7)
        Console.WriteLine("seven");
    else if (currentDigit == 8)
        Console.WriteLine("eight");
    else if (currentDigit == 9)
        Console.WriteLine("nine");
}