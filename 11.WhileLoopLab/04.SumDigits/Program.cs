namespace _04.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()); // example: int 2345

            var sum = 0.0;
            int i = 0;
            string numberStr = number.ToString(); // string 2345
            
            while (i < numberStr.Length)
            {
                var digit = int.Parse(numberStr[i].ToString());
                i++;
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}