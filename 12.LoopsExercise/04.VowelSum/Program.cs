namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nTimes = int.Parse(Console.ReadLine());

            var totalValue = 0;

            for (int i = 1; i <= nTimes; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                switch (currentChar)
                {
                    case 'a':
                        totalValue += 1;
                        break;
                    case 'e':
                        totalValue += 2;
                        break;
                    case 'i':
                        totalValue += 3;
                        break;
                    case 'o':
                        totalValue += 4;
                        break;
                    case 'u':
                        totalValue += 5;
                        break;
                }
            }

            Console.WriteLine(totalValue);
        }
    }
}