string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double price = 0;

switch (season)
{
    case "Spring":
        if (type == "Hotel")
        {
            price = 30 * days * 0.8;
            break;
        }
        else
            price = 10 * days * 0.8;
        break;
    case "Summer":
        if (type == "Hotel")
        {
            price = 50 * days * 1.0;
            break;
        }
        else
            price = 30 * days * 1.0;
        break;
    case "Autumn":
        if (type == "Hotel")
        {
            price = 20 * days * 0.7;
            break;
        }
        else
            price = 15 * days * 0.7;
        break;
    case "Winter":
        if (type == "Hotel")
        {
            price = 40 * days * 0.9;
            break;
        }
        else
            price = 10 * days * 0.9;
        break;
}

Console.WriteLine($"{price:F2}");
