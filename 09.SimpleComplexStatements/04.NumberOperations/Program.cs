namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            var finalPrice = 0.00;

            switch (mathOperator)
            {
                case "+":
                    finalPrice = num1 + num2; break;
                case "-":
                    finalPrice = num1 - num2; break;
                case "*":
                    finalPrice = num1 * num2; break;
                case "/":
                    finalPrice = num1 / num2; break;
            }

            Console.WriteLine($"{num1} {mathOperator} {num2} = {finalPrice:F2}");
        }
    }
}