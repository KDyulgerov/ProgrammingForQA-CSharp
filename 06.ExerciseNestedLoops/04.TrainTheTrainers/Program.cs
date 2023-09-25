namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            double overallGrade = 0;
            int presentationCounter = 0;

            while (true)
            {
                string presentation = Console.ReadLine();

                if(presentation == "Finish")
                {
                    break;
                }

                double avrGrade = 0;
                presentationCounter++;

                for (int jury = 1; jury <= juryNumber; jury++)
                {
                    double juryGrade = double.Parse(Console.ReadLine());
                    avrGrade += juryGrade;
                    overallGrade += juryGrade;

                }
                Console.WriteLine($"{presentation} - {avrGrade / juryNumber:F2}.");
            }
            Console.WriteLine($"Student's final assessment is {overallGrade / juryNumber / presentationCounter:F2}.");
        }
    }
}