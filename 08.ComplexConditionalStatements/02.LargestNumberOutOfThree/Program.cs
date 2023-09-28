namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            var maxNumber = int.MinValue;

            if (num1 > num2 && num1 > num3)
            {
                maxNumber = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                maxNumber = num2;
            }
            else
            {
                maxNumber = num3;
            }

            Console.WriteLine(maxNumber);
        }
    }
}