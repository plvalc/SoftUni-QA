using System.Collections.Specialized;

int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());

for (int i = startNum; i <= endNum; i++)
{
    int count = 1;
    for (int j = 2; j <= i; j++)
    {


        if (i % j == 0)
            count++;
        if (count > 2)
            break;
    }
    if(count == 2)
    {
        Console.Write($"{i} ");
    }

}
