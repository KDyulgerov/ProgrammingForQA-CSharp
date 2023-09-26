namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            double price = 0;

            if (ticketType == "student")
                price = 1.00;
            else if (ticketType == "regular")
                price = 1.60;
            else
            {
                Console.WriteLine("Invalid ticket type!");
                return;
            }   
            Console.WriteLine($"${price:F2}");

        }
    }
}