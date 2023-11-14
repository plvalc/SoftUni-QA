int number = int.Parse(Console.ReadLine());

string type = "";

if (number < 0)
{
    type = "negative";
}
else if (number > 0)
{
    type = "positive";
}
else
    type = "zero";

Console.WriteLine(type);
