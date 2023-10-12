int n = int.Parse(Console.ReadLine());

int sum = 0;

for  (int i = 0; i < n; i++)
{
    char currentChar = char.Parse(Console.ReadLine());

    if (currentChar == 'a')
        sum += 1;
    else if (currentChar == 'e')
        sum += 2;
    else if (currentChar == 'i')
        sum += 3;
    else if (currentChar == 'o')
        sum += 4;
    else if (currentChar == 'u')
        sum += 5;
}

Console.WriteLine(sum);
