namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character = Console.ReadLine();

            if (character == "A" 
                || character == "a"
                || character == "E"
                || character == "e"
                || character == "O"
                || character == "o"
                || character == "I"
                || character == "i"
                || character == "U"
                || character == "u")
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}