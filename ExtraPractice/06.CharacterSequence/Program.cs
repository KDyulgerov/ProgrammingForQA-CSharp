namespace _06.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // Example 'SoftUni"

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}