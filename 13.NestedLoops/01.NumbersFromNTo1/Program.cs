namespace _01.NumbersFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}