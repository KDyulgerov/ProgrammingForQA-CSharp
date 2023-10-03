namespace _05.NumbersFrom1ToNOver3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}