static int MathPow(int bNum, int powNum)
{
    int result = 1;

    for (int i = 1; i<= powNum; i++)
    {
        result *= bNum;
    }
    return result;
}

int baseNum = int.Parse(Console.ReadLine());
int powNum = int.Parse(Console.ReadLine());

Console.WriteLine(MathPow(baseNum, powNum));
