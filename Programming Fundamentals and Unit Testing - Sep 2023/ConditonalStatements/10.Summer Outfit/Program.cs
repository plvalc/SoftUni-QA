//Same task as /Programming Fundamentals and Unit Testing/Statements/02.Summer Clothing

int temp = int.Parse(Console.ReadLine());
String timeOfDay = Console.ReadLine();

String clothing = "";
String shoes = "";

switch (timeOfDay)
{
    case "Morning":
        {
            if (10 <= temp && temp <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (temp <= 24)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (temp >= 25)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            break;
        }
    case "Afternoon":
        {
            if (10 <= temp && temp <= 18)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (temp <= 24)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (temp >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }
            break;
        }
    case "Evening":
        {
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        }
}
Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");