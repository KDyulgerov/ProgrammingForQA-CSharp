namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            double num1 = 0;
            double num2 = 0;

            if (type == "square")
            {
                num1 = double.Parse(Console.ReadLine());
                area = num1 * num1;
            }
            else if (type == "rectangle")
            {
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                area = num1 * num2;
            }
            else if (type == "circle")
            {
                num1 = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(num1, 2);
            }
            else
            {
                Console.WriteLine("Invalid figure.");
                return;
            }

            Console.WriteLine($"{area:F2}");
        }
    }
}