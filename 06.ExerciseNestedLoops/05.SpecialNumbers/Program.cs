using System.Runtime.CompilerServices;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string digitNum = i.ToString(); // 1111

                bool isSpecial = true;
                for (int j = 0; j < digitNum.Length; j++) 
                {
                    int currentDigit = int.Parse(digitNum[j].ToString());

                    if (currentDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if (number % currentDigit != 0)
                    {
                        isSpecial = false;
                    }
                }
                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}