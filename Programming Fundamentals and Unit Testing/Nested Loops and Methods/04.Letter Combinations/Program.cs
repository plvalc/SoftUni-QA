char s = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char x = char.Parse(Console.ReadLine());

int count = 0;

for (char i = s; i <= e; i++)
{
    if ( i != x)
    {
        for (char j = s; j <= e; j++)
        {
            if ( j != x )
            {
                for (char  k = s; k <= e; k++)
                {
                    if (k != x )
                    {
                        Console.Write($"{i}{j}{k} ");
                        count++;
                    }
                }
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(count);