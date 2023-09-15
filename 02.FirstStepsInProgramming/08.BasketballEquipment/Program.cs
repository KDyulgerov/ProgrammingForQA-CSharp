namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxYearly = int.Parse(Console.ReadLine());

            double sneakers = taxYearly - (taxYearly * 0.40);
            double basketTeam = sneakers - (sneakers * 0.20);
            double basketball = basketTeam / 4;
            double accessories = basketball / 5;

            double totalPrice = taxYearly + sneakers + basketTeam + basketball + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}