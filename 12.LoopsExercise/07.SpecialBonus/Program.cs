namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopNum = int.Parse(Console.ReadLine());

            var currentNum = 0;
            var lastNum = 0;

            while (currentNum != stopNum)
            {
                lastNum = currentNum;
                currentNum = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(lastNum * 1.20);
        }
    }
}