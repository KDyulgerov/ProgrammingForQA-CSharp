using System.Xml.Schema;

namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine(); // "room for one person", "apartment" or "president apartment"
            string assesment = Console.ReadLine(); // "positive" or "negative"

            int nights = days - 1;
            double priceOnePerson = 118;
            double priceApart = 155;
            double pricePresident = 235;

            double totalPrice = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    totalPrice = priceOnePerson * nights;
                    break;

                case "apartment":
                    totalPrice = priceApart * nights;
                    if (days < 10)
                    {
                        totalPrice *= 0.70;
                    } else if (days >= 10 && days <= 15)
                    {
                        totalPrice *= 0.65;
                    } else if (days > 15)
                    {
                        totalPrice *= 0.50;
                    }
                    break;

                case "president apartment":
                    totalPrice = pricePresident * nights;
                    if (days < 10)
                    {
                        totalPrice *= 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        totalPrice *= 0.80;
                    }
                    break;
            }
            if (assesment == "positive")
            {
                totalPrice *= 1.25;
            } else if (assesment == "negative")
            { 
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}