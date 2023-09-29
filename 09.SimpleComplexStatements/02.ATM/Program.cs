namespace _02.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var balance = int.Parse(Console.ReadLine());
            var withdraw = int.Parse(Console.ReadLine());
            var limit = int.Parse(Console.ReadLine());

            if (limit < withdraw)
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else if (balance < withdraw)
            {
                Console.WriteLine("Insufficient availability.");
            }
            else
            {
                Console.WriteLine("The withdraw was successful.");
            }
        }
    }
}