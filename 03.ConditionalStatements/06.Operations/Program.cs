using System.Transactions;

namespace _06.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            double reminder = 0;
            string modeDiv = "";

            switch (operation)
            {
                case "+":
                case "-":
                case "*":

                    switch (operation)
                    {
                        case "+":

                            result = number1 + number2;
                            break;

                        case "-":

                            result = number1 - number2;
                            break;

                        case "*":

                            result = number1 * number2;
                            break;
                    }
                    if (result % 2 == 0)
                    {
                        modeDiv = "even";
                    }
                    else
                    {
                        modeDiv = "odd";
                    }
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - {modeDiv}");
                    break;


                case "%":
                    if (number2 != 0)
                    {
                        result = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {result}");
                    }
                    else
                        // Cannot devide by 0
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    break;

                case "/":
                    if (number2 != 0)
                    {
                        double dres = (double)number1 / number2;
                        Console.WriteLine($"{number1} / {number2} = {dres:F2}");
                    }
                    else
                        // Cannot devide by 0
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    break;
                


            }

        }
    }
}