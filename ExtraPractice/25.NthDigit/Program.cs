namespace _25.NthDigit
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            int FindNthDigit(int number, int index) // 1234
            {
                int count = 0;
                int rightNum = 0;

                while (number > 0)
                {
                    count++;
                    if (count == index)
                    {
                        rightNum = number % 10;
                    }
                    number /= 10;
                }

                return rightNum;
            }

            int userNum = int.Parse(Console.ReadLine());
            int userIndex = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(userNum, userIndex));
        }
    }
}