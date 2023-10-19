List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers.RemoveAll(number => number < 0);

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}

numbers.Reverse();
Console.WriteLine(string.Join(" ", numbers));
