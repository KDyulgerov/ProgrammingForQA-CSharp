namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i += 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}