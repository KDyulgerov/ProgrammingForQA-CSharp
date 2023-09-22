namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());

            int poorGrades = 0;
            int taskCounter = 0;
            string lastTask = "";
            double avrgScore = 0;

            while (true)
            {
                string taskName = Console.ReadLine();

                if (taskName != "Enough")
                {
                    lastTask = taskName;
                }
                
                if (taskName == "Enough")
                {
                    break;
                }

                int taskGrade = int.Parse(Console.ReadLine());

                if (taskGrade <= 4)
                {
                    poorGrades += 1;
                }
                if (poorGrades >= maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                    break;
                }
                taskCounter += 1;
                avrgScore += taskGrade;
            }
            if (poorGrades < maxPoorGrades) 
            {
                Console.WriteLine($"Average score: {avrgScore/taskCounter:F2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}