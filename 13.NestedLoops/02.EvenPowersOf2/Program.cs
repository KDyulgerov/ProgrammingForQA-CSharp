namespace _02.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    var sum = Math.Pow(2, i);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}