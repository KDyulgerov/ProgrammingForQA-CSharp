namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i += 1)
            {
                var result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}