namespace _03.SumOfPrimeAndNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            while(true)
            {
                string command = Console.ReadLine() ?? "0";

                if (command == "stop") 
                {
                    break;
                }

                int number = int.Parse(command);
                int divisors = 0;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;   
                }

                for (int i = 1; i <= number; i += 1)
                {
                    if (number % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    sumPrime += number;
                }
                else 
                    sumNonPrime += number;
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}