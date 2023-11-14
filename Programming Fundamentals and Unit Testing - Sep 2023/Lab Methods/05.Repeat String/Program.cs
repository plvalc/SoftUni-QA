string RepeatString(string text, int repeat)
{
    string newText = "";
    for (int i = 0; i < repeat; i++)
    {
        newText += text;
    }
    return newText;
}

string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(text, count));