namespace _18.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var badGrades = int.Parse(Console.ReadLine());

            var currentBadGrades = 0;
            var totalScore = 0.0;
            var totalTasks = 0;
            string lastProblem = "";

            while (badGrades > currentBadGrades)
            {
                string nameTask = Console.ReadLine();

                if (nameTask == "Enough")
                {
                    break;
                }
                var gradeTask = double.Parse(Console.ReadLine());

                lastProblem = nameTask;
                totalTasks++;
                totalScore += gradeTask;

                if (gradeTask <= 4)
                {
                    currentBadGrades++;
                }
            }

            if (currentBadGrades < badGrades)
            {
                Console.WriteLine($"Average score: {totalScore / totalTasks:F2}");
                Console.WriteLine($"Number of problems: {totalTasks}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {currentBadGrades} poor grades.");
            }
        }
    }
}