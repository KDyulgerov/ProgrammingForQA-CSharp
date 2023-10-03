namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for (char ch = start; ch <= end; ch++)
            {
                if (ch < end)
                {
                    Console.Write(ch + " ");
                }
                else
                {
                    Console.Write(ch);
                }
            }
        }
    }
}