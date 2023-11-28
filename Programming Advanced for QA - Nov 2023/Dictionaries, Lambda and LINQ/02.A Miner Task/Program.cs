Dictionary<string, double> resources = new();
string resource = Console.ReadLine();
while (resource != "stop")
{
    if (!resources.ContainsKey(resource))
        resources.Add(resource, 0);
    double qty = double.Parse(Console.ReadLine());
    resources[resource] += qty;

    resource = Console.ReadLine();
}
foreach (var kvp in resources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}