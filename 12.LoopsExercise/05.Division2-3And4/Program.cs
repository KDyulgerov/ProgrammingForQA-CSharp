namespace _05.Division2_3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nTimes = int.Parse(Console.ReadLine());

            var count2 = 0;
            var count3 = 0;
            var count4 = 0;

            for (int i = 1; i <= nTimes; i++)
            {
                var currenNum = int.Parse(Console.ReadLine());

                if (currenNum % 2 == 0)
                {
                    count2++;
                }
                if (currenNum % 3 == 0)
                {
                    count3++;
                }
                if (currenNum % 4 == 0)
                {
                    count4++;
                }
            }

            var percent2 = count2 * 1.0 / nTimes * 100;
            var percent3 = count3 * 1.0 / nTimes * 100;
            var percent4 = count4 * 1.0 / nTimes * 100;

            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
            Console.WriteLine($"{percent4:F2}%");
        }
    }
}