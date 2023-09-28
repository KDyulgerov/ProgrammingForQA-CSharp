namespace _03.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());

            if (points >= 0 && points <= 3)
            {
                points += 5;
            }
            else if (points > 3 && points <= 6)
            {
                points += 15;
            }
            else if (points > 6 && points <= 9)
            {
                points += 20;
            }

            Console.WriteLine(points);
        }
    }
}