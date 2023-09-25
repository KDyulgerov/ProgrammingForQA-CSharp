namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standartTickets = 0;
            int kidTickets = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                int currentSeats = 0;
                
                while (currentSeats < capacity)
                {
                    string type = Console.ReadLine();

                    if (type == "End")
                    {
                        break;
                    }
                   
                    currentSeats++;

                    switch (type)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standartTickets++; break;
                        case "kid": kidTickets++; break;
                    }
                }
                Console.WriteLine($"{movie} - {currentSeats * 100.0 / capacity:F2}% full.");
            }
             int totalTickets = studentTickets + standartTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:F2}% student tickets.");
            Console.WriteLine($"{standartTickets * 100.0 / totalTickets:F2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:F2}% kids tickets.");
        }
    }
}