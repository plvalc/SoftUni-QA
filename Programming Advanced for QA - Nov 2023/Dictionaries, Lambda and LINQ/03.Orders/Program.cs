using System.Resources;

Dictionary<string, List<double>> products = new();

string[] input = Console.ReadLine().Split().ToArray();

while (input[0] != "buy")
{
    string product = input[0];
    double price = double.Parse(input[1]);
    double qty = double.Parse(input[2]);

    if (!products.ContainsKey(input[0]))
    {
        products.Add(product, new());
        products[product].Add(price);
        products[product].Add(qty);
    }
    else
    {
        products[product][0] = price;
        products[product][1] += qty;
    }

    input = Console.ReadLine().Split().ToArray();
}
foreach (var kvp in products)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:F2}");
}