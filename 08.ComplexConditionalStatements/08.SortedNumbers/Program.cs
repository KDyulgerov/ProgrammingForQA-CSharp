namespace _08.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            if (number1 < number2 && number2 < number3)
            {
                Console.WriteLine("Ascending");
            }
            else if (number1 > number2 && number2 > number3)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}