Dictionary<char, int> chars = new();
string input = Console.ReadLine();

foreach (char ch in input)
{
    if (ch == ' ')
        continue;
    if (!chars.ContainsKey(ch))
        chars.Add(ch, 1);
    else
        chars[ch]++;
}

foreach (var ch in chars)
{
    Console.WriteLine($"{ch.Key} -> {ch.Value}");
}