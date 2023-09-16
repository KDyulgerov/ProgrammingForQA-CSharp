namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectTpye = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            double totalTickets = rows * colums;

            switch(projectTpye)
            {
                case "Premiere": income = 12.00; break;
                case "Normal": income = 7.50; break;
                case "Discount": income = 5.00; break;

            }
            double totalincome = income * totalTickets;
            Console.WriteLine($"{totalincome:F2} leva");
        }
    }
}