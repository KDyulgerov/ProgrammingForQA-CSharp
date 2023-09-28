using System.Diagnostics.SymbolStore;

namespace _01.MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();

            var productPrice = 0.00;

            if (day == "Weekday")
            {
                switch (product)
                {
                    case "Banana":
                        productPrice = 2.50;
                        break;
                    case "Apple":
                        productPrice = 1.30;
                        break;
                    case "Kiwi":
                        productPrice = 2.20;
                        break;
                }
            }
            else if (day == "Weekend")
            {
                switch (product)
                {
                    case "Banana":
                        productPrice = 2.70;
                        break;
                    case "Apple":
                        productPrice = 1.60;
                        break;
                    case "Kiwi":
                        productPrice = 3.00;
                        break;
                }
            }
            Console.WriteLine($"{productPrice:F2}");
        }
    }
}