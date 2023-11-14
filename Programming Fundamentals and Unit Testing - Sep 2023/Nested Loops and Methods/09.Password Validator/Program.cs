static bool ValidLettersAndDigits(string pass)
{
    for (int i = 0; i < pass.Length; i++)
    {
        if (char.IsLetterOrDigit(pass[i]) == false)
            return false;
    }

    return true;
}

static bool EnoughDigits(string pass, int num)
{
    int count = 0;
    for (int j = 0; j < pass.Length; j++)
    {
        if (char.IsDigit(pass[j]))
        { count++; }
        if (count >= num)
            return true;
    }
    return false;
}


string pass = Console.ReadLine();

bool isValidLength = pass.Length >= 6 && pass.Length <= 10;
bool isValidLettersDigits = ValidLettersAndDigits(pass);
bool isValidDigits = EnoughDigits(pass, 2);

if ( isValidLength && isValidLettersDigits && isValidDigits)
    Console.WriteLine("Password is valid");
else
{
    if (isValidLength == false)
        Console.WriteLine("Password must be between 6 and 10 characters");
    if (isValidLettersDigits == false)
        Console.WriteLine("Password must consist only of letters and digits");
    if (isValidDigits == false)
        Console.WriteLine("Password must have at least 2 digits");
}
