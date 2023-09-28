namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeMovie = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var seats = int.Parse(Console.ReadLine());

            var price = 0.00;

            if (typeMovie == "Premiere")
            {
                price = 12.00;
            }
            else if (typeMovie == "Normal")
            {
                price = 7.50;
            }
            else if (typeMovie == "Discount")
            {
                price = 5.00;
            }
            var totalPrice = rows * seats * price;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}