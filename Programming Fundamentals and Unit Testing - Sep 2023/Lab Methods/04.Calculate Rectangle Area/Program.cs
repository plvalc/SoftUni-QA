static int CalculateRectangleArea(int width, int length)
{
    int result = width * length;
    return result;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateRectangleArea(a, b));
