int stopNum = int.Parse(Console.ReadLine());
int currentNum = int.Parse(Console.ReadLine());
int prevNum = currentNum;

while (currentNum != stopNum)
{
    prevNum = currentNum;
    currentNum = int.Parse(Console.ReadLine());

}
Console.WriteLine(prevNum * 1.2);