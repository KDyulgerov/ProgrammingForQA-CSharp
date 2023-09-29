namespace _10.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = "Shirt";
            string shoes = "Moccasins";

            if ((timeOfDay == "Morning" && temperature >= 25)
                || (timeOfDay == "Afternoon" && temperature > 18 && temperature <= 24))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (timeOfDay == "Morning" && temperature <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (timeOfDay == "Afternoon" && temperature >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}