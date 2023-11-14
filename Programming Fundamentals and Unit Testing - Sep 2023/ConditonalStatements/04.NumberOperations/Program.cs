int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
string op = Console.ReadLine();

double result = 0;

if (op == "+")
    result = (n1 + n2) * 1.0;
else if (op == "-")
    result = (n1 - n2) * 1.0;
else if (op == "*")
    result = n1 * n2 * 1.0;
else
    result = n1 / n2 * 1.0;

Console.WriteLine($"{n1} {op} {n2} = {result:F2}");
