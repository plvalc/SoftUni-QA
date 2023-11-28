Dictionary<string, List<string>> company = new();

string[] input = Console.ReadLine().Split(" -> ").ToArray();

while (input[0] != "End")
{
    string companyName = input[0];
    string employee = input[1];

    if (!company.ContainsKey(companyName))
    {
        company.Add(companyName, new());
        company[companyName].Add(employee);
    }
    else
    {
        if (!company[companyName].Contains(employee))
        {
            company[companyName].Add(employee);
        }
    }
    input = Console.ReadLine().Split(" -> ").ToArray();
}

foreach(var currentCompany in company)
{
    Console.WriteLine(currentCompany.Key);
    foreach(var currentEmployee in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentEmployee}");
    }
}