namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int totalDays = int.Parse(Console.ReadLine());

            int totalTimeForBook = totalPages / pagesPerHour;
            int requiredHours = totalTimeForBook / totalDays;

            Console.WriteLine(requiredHours);
        }
    }
}