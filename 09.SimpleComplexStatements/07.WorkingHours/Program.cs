namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            string status = "";

            if (dayOfWeek == "Sunday")
            {
                status = "closed";
            }
            else if (dayOfWeek == "Monday"
                     || dayOfWeek == "Tuesday"
                     || dayOfWeek == "Thursday"
                     || dayOfWeek == "Wednesday"
                     || dayOfWeek == "Thursday"
                     || dayOfWeek == "Friday"
                     || dayOfWeek == "Saturday")
                if (hour >= 10 && hour <= 18)
                {
                    status = "open";
                }
                else
                {
                    status = "closed";
                }

            Console.WriteLine(status);
        }
    }
}