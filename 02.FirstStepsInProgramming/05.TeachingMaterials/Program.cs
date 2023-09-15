using System.Xml.Schema;

namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPens = int.Parse(Console.ReadLine());
            int numberMarkers = int.Parse(Console.ReadLine());
            int litersBoardCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalPrice = (numberPens * 5.80) + (numberMarkers * 7.20) + (litersBoardCleaner * 1.20);
            double discountPercent = discount / 100.0;
            double discountAmount = totalPrice * discountPercent;

            Console.WriteLine(totalPrice - discountAmount);
        }
    }
}