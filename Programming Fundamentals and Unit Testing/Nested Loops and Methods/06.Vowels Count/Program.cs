static void CountAndPrintVowels(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char digit = text[i];
        switch (digit)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                count++;
                break;
        }
    }
    Console.WriteLine(count);
}

string text = Console.ReadLine();

CountAndPrintVowels(text);