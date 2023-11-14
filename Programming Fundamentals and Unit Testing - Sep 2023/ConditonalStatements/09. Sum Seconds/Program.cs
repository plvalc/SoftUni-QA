int s1 = int.Parse(Console.ReadLine());
int s2 = int.Parse(Console.ReadLine());
int s3 = int.Parse(Console.ReadLine());

int min = (s1 + s2 + s3) / 60;
int sec = (s1 + s2 + s3) % 60;

Console.WriteLine($"{min}:{sec:D2}");