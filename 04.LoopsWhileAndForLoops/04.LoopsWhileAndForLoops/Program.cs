using System.Threading.Channels;

namespace _04.LoopsWhileAndForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 1)
            {
                Console.WriteLine(i);
            }

         
        }
    }
}