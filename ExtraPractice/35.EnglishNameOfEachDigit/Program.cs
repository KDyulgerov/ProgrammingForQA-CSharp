int number = int.Parse(Console.ReadLine());

string numbString = number.ToString();

List<string> numbers = new() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

for (int i = numbString.Length - 1; i >= 0; i--)
{
    int currentNum = int.Parse(numbString[i].ToString());
    Console.WriteLine(numbers[currentNum - 1]);
}