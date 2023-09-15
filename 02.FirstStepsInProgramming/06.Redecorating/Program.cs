namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine()) + 2;
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int craftmanWorkHours = int.Parse(Console.ReadLine());
           
            double naylonPrice = naylon * 1.50;
            double paintPrice = (paint * 14.50);
            double paintTotalPrice = paintPrice + (paintPrice * 0.10);
            double thinnerPrice = thinner * 5;

            double totalPrice = naylonPrice + paintTotalPrice + thinnerPrice + 0.40;

            double craftManPrice = (totalPrice * 0.30) * craftmanWorkHours;

            double totalSum = craftManPrice + totalPrice;

            Console.WriteLine(totalSum);    
        }
    }
}