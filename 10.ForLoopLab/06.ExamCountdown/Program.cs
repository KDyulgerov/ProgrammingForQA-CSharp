using System.Threading.Channels;

namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            for (int i = days; i >= 1; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}