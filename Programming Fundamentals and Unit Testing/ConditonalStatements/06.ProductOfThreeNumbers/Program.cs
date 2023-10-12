int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

string result = "";

if (n1 == 0 || n2 == 0 || n3 == 0)
    result = "zero";
else if (n1 > 0 && n2 > 0 && n3 > 0)
    result = "positive";
else if (n1 > 0 && n2 < 0 && n3 < 0)
    result = "positive";
else if (n1 < 0 && n2 < 0 && n3 > 0)
    result = "positive";
else if (n1 < 0 && n2 > 0 && n3 < 0)
    result = "positive";
else
    result = "negative";

Console.WriteLine(result);


