namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int checkedBooks = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();
                
                if (currentBook == favBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                else if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }
                checkedBooks++;
            }
        }
    }
}