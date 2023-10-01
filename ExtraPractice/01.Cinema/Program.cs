namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var price = 0.00;

            if (type == "Premiere")
            {
                price = 12.00;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5.00;
            }

            var totalPrice = rows * cols * price;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}