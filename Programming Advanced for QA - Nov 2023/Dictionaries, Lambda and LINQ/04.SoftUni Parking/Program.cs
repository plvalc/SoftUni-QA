using System.Resources;

Dictionary<string, string> parking = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();
    string command = input[0];
    string user = input[1];

    if (command == "register")
    {
        string number = input[2];
        if (!parking.ContainsKey(user))
        {
            parking.Add(user, number);
            Console.WriteLine($"{user} registered {number} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {number}");
        }
    }
    else if (command == "unregister")
    {
        if (parking.ContainsKey(user))
        {
            parking.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
    }

}
foreach (var kvp in parking)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}