namespace _26.IntegerToBase
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string IntegerToBase(int number, int toBase)
            {
                string result = "";

                while (number > 0)
                {
                    int remainder = number % toBase;

                    result = remainder + result;

                    number /= toBase;
                }

                return result;
            }

            int userNum = int.Parse(Console.ReadLine());
            int userBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(userNum, userBase));
        }
    }
}