namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var currentPow = 1;

            for (int i = 1; i <= power; i++)
            {
                currentPow *= number;
            }

            Console.WriteLine(currentPow);
        }   
    }
}