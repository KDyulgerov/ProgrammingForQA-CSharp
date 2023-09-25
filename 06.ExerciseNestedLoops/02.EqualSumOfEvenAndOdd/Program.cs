namespace _02.EqualSumOfEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int evenSum = 0;
                int oddSum = 0;

                string currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}