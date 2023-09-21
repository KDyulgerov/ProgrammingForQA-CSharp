namespace _09.TheSmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                int number = int.Parse(command);

                if (number < minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine(minNumber);
        }
    }
}