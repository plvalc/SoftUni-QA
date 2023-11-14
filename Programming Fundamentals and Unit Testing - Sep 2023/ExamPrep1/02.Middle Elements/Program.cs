int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int num1 = numbers[(numbers.Length / 2) - 1];
int num2 = numbers[numbers.Length / 2];

double average = (num1 + num2 * 1.0) / 2;
Console.WriteLine($"{average:f2}");