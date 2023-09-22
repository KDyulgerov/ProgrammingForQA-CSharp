namespace _09.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * length * height;

            int boxes = 0;
            int currentSpace = 0;

            while (currentSpace <= volume)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                boxes = int.Parse(command);
                currentSpace += boxes;

            }
            int diff = Math.Abs(currentSpace - volume);

            if (currentSpace > volume)
            {
                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }
            else
                Console.WriteLine($"{diff} Cubic meters left.");
        }
    }
}