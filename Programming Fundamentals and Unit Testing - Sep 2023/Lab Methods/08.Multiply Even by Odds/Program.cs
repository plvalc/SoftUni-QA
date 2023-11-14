static int GetSumOfEvenDigits(int num)
{
    int sumEven = 0;
    for (int i = num; i>0; i /= 10)
    {
        int digit = i % 10;
        if (digit % 2 == 0)
            sumEven += digit;
    }
    return sumEven;
}

static int GetSumOfOddDigits(int num)
{
    int sumOdd = 0;
    for (int i = num; i > 0; i /= 10)
    {
        int digit = i % 10;
        if (digit % 2 != 0)
            sumOdd += digit;
    }
    return sumOdd;
}

static int GetMultipleOfEvenAndOdds(int num)
{
    int sumEven = GetSumOfEvenDigits(num);
    int sumOdd = GetSumOfOddDigits(num);
    int result = sumEven * sumOdd;
    return result;
}

int num = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleOfEvenAndOdds(num));