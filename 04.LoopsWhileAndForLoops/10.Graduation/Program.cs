using System.Diagnostics.Contracts;

namespace _10.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int classNubmer = 1;
            int failureCounter = 0;
            double totalGrade = 0;

            while (classNubmer <= 12)

            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    failureCounter += 1;
                }
                if (failureCounter > 1)
                {
                    Console.WriteLine($"{nameStudent} has been excluded at {classNubmer - 1} grade");
                    break;

                }
                classNubmer += 1;
                totalGrade += grade;
            }
            double avrGrade = totalGrade / 12;

            if (failureCounter <= 1)
            {
                Console.WriteLine($"{nameStudent} graduated. Average grade: {avrGrade:F2}");
            }     

        }
    }
}