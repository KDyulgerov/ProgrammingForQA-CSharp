namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double vegetarianPrice = vegetarianMenu * 8.15;

            double sumMenus = chickenPrice + fishPrice + vegetarianPrice;
            double dessertsum = sumMenus * 0.20;

            double totalPrice = sumMenus + dessertsum + 2.50;

            Console.WriteLine(totalPrice);
        }
    }
}