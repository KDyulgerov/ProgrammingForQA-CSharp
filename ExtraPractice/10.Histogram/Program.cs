namespace _10.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var readNumber = double.Parse(Console.ReadLine());

            var group1 = 0.0;
            var group2 = 0.0;
            var group3 = 0.0;
            var group4 = 0.0;
            var group5 = 0.0;

            for (int i = 0; i < readNumber; i++)
            {
                var currentNum = double.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    group1 += 1;
                }
                else if (currentNum >= 200 && currentNum <= 399)
                {
                    group2 += 1;
                }
                else if (currentNum >= 400 && currentNum <= 599)
                {
                    group3 += 1;
                }
                else if (currentNum >= 600 && currentNum <= 799)
                {
                    group4 += 1;
                }
                else if (currentNum >= 800)
                {
                    group5 += 1;
                }
            }
            Console.WriteLine($"{group1 / readNumber * 100:F2}%");
            Console.WriteLine($"{group2 / readNumber * 100:F2}%");
            Console.WriteLine($"{group3 / readNumber * 100:F2}%");
            Console.WriteLine($"{group4 / readNumber * 100:F2}%");
            Console.WriteLine($"{group5 / readNumber * 100:F2}%");
        }
    }
}