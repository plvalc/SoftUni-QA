static void CalcAndPrintPrderPrice(string product, int quantity)
{
    double price = 0;
    if (product == "coffee") price = quantity * 1.50;
    else if (product == "water") price = quantity * 1.00;
    else if (product == "coke") price = quantity * 1.40;
    else if (product == "snacks") price = quantity * 2.00;

    Console.WriteLine($"{price:F2}");
}

string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

CalcAndPrintPrderPrice(product, quantity);