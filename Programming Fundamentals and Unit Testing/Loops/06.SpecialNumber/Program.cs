int num = int.Parse(Console.ReadLine());

bool isSpecial = true;
int currentNum = num;

while (currentNum > 0)
{
    int digit = currentNum % 10;
    currentNum /= 10;

    if (num % digit != 0)
    {
        isSpecial = false;
        break;
    }
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}