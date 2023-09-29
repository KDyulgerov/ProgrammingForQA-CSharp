namespace _08.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            bool isValid = (number >= 100 && number <= 200) || number == 00;
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}