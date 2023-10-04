namespace _02.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}