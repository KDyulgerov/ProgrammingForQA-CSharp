namespace _23.MinMethod
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int GetMin(int number1, int number2)
            {
                int minNum = int.MaxValue;

                if (number1 < number2)
                {
                    minNum = number1;
                }
                else
                {
                    minNum = number2;
                }

                return minNum;
            }

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var min = GetMin(GetMin(num1, num2), num3);

            Console.WriteLine(min);
        }

    }
}