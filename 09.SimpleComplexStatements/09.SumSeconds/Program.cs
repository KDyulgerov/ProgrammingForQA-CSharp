using System.Xml.Schema;

namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = int.Parse(Console.ReadLine());
            var result2 = int.Parse(Console.ReadLine());
            var result3 = int.Parse(Console.ReadLine());

            var totalResult = result1 + result2 + result3;
            var minutes = totalResult / 60;
            var seconds = totalResult % 60;

            string leadingZero = "";
            if (seconds < 10)
                leadingZero = "0";

            Console.WriteLine($"{minutes}:{leadingZero}{seconds}");
        }
    }
}