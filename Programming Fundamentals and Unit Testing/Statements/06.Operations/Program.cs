namespace _06.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            String op = Console.ReadLine();

            int result = 0;
            String evOdd = "";

            switch (op)
            {
                case "+":
                case "-":
                case "*":
                switch (op)
                {
                    case "+":
                        {
                            result = n1 + n2; break;
                        }
                    case "-":
                        {
                            result = n1 - n2; break;
                        }
                    case "*":
                        {
                            result = n1 * n2; break;
                        }
                }

            if (result % 2 == 0)
                evOdd = "- even";
            else
                evOdd = "- odd";
            Console.WriteLine($"{n1} {op} {n2} = {result} {evOdd}");
                    break;
            }

            switch (op) 
            {

                case "/":
                case "%":
                    if (n2 != 0)
                    {
                        if (op == "/")
                        {
                            double dResult = n1 / n2 * 1.0;
                            Console.WriteLine($"{n1} / {n2} = {dResult:f2}");
                        }
                        else if (op == "%")
                        {
                            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                        }
                    }
                    else
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    break;
            }
            

            
        }
    }
}