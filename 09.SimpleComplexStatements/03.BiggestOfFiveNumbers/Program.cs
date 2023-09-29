namespace _03.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());
            var num5 = int.Parse(Console.ReadLine());

            var maxNumber = int.MinValue;

            if (num1 > maxNumber)
                maxNumber = num1;
            if (num2 > maxNumber)
                maxNumber = num2;
            if (num3 > maxNumber)
                maxNumber = num3;
            if (num4 > maxNumber)
                maxNumber = num4;
            if (num5 > maxNumber)
                maxNumber = num5;

            Console.WriteLine(maxNumber);
        }
    }
}