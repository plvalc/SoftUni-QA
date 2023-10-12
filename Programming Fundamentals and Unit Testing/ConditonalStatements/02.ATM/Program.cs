int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

string result = "";

if (withdraw <= balance)
    result = "The withdraw was successful.";
else if (withdraw > limit)
    result = "The limit was exceeded.";
else
    result = "Insufficient availability.";

Console.WriteLine(result);