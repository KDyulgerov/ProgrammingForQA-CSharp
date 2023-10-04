using System.Data;

namespace _06.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string command = "";

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "Inc")
                {
                    number++;
                }
                else if (command == "Dec")
                {
                    number--;
                }
            }

            Console.WriteLine(number);
        }
    }
}