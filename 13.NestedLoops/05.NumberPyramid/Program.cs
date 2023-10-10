namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var currentNum = 1;

            for (int row = 1; row <= num && currentNum <= num; row += 1)
            {
                for (int col = 1; col <= row && currentNum <= num; col += 1)
                {
                    Console.Write(currentNum + " ");
                    currentNum += 1;

                }

                Console.WriteLine();
            }
        }
    }
}