namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12

            double depositAmount = double.Parse(Console.ReadLine());
            int termMonths = int.Parse(Console.ReadLine());
            double amountInterest = double.Parse(Console.ReadLine());

            double percentInterest = amountInterest / 100.0;

            double amount = depositAmount + termMonths * (depositAmount * percentInterest) / 12;

            Console.WriteLine(amount);


        }
    }
}