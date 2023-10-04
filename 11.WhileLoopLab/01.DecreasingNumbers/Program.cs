namespace _01.DecreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= number)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}