namespace _08.OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examTimeH = int.Parse(Console.ReadLine());
            int examTimeM = int.Parse(Console.ReadLine());
            int arrivalTimeH = int.Parse(Console.ReadLine());
            int arrivalTimeM = int.Parse(Console.ReadLine());

            int hoursExamConvertM = examTimeH * 60 + examTimeM;
            int hoursArrivalConvertM = arrivalTimeH * 60 + arrivalTimeM;

            int diff = hoursExamConvertM - hoursArrivalConvertM;

            string status = ""; // "Late" "On time" or "Late"
            string comparison = ""; // "before" or "after"


            if (diff >= 0 && diff <= 30)
            {
                status = "On time";
                comparison = "before";
            }
            else if (diff < 0)
            {
                status = "Late";
                comparison = "after";
                diff = -diff;
            }
            else
            {
                status = "Early";
                comparison = "before";
            }

            int comparisonH = diff / 60;
            int comparisonM = diff % 60;

            Console.WriteLine(status);
            if (comparisonH > 0)
            {
                Console.WriteLine($"{comparisonH}:{comparisonM:D2} hours {comparison} the start");
            }
            else if (comparisonM > 0)
            {
                Console.WriteLine($"{comparisonM} minutes {comparison} the start");
            }
        }
    }
}