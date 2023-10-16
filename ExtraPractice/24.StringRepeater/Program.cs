namespace _24.StringRepeater
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            void RepeatString(string str, int count)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(str);
                }
            }

            string userStr = Console.ReadLine();
            int userCount = int.Parse(Console.ReadLine());

            RepeatString(userStr, userCount);
        }
    }
}