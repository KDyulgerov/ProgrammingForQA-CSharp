namespace _08.TheGreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                int number = int.Parse(command);
                
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}