namespace _03.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= number)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}