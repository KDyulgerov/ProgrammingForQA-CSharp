namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 7; i <= number; i += 1)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}