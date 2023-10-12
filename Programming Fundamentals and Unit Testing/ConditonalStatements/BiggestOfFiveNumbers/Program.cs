int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());

int biggest = n1;

if (n2 > biggest)
    biggest = n2;
if (n3 > biggest)
    biggest = n3;
if (n4 > biggest)
    biggest = n4;
if (n5 > biggest)
    biggest = n5;

Console.WriteLine(biggest);
