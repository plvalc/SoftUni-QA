static int CompareInt(string str1, string str2)
{
    int num1 = int.Parse(str1);
    int num2 = int.Parse(str2);

    if (num1 > num2) return num1;
    else return num2;
}

static char CompareChar(string str1, string str2)
{
    char ch1 = char.Parse(str1);
    char ch2 = char.Parse(str2);

    if (ch1 > ch2) return ch1;
    else return ch2;

}

static string CompareStrings(string str1, string str2)
{
    if ((str1.CompareTo(str2) > 0)) return str1;
    else return str2;
}

string valueType = Console.ReadLine();
string val1 =  Console.ReadLine();
string val2 =  Console.ReadLine();

if (valueType == "int") Console.WriteLine(CompareInt(val1, val2));
else if (valueType == "char") Console.WriteLine(CompareChar(val1, val2));
else if (valueType == "string") Console.WriteLine(CompareStrings(val1, val2));


