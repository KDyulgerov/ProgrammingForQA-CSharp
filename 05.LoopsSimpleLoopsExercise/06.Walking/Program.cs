namespace _06.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int goal = 10000;
            int totalSteps = 0;

            while (totalSteps < goal)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }

                int steps = int.Parse(command);

                totalSteps += steps;
            }
            int diff = Math.Abs(totalSteps - goal);
            if(totalSteps >= goal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{diff} more steps to reach goal.");
            }

        }
    }
}