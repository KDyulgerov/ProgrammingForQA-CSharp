using System.Linq.Expressions;

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    int elementNum = int.Parse(commandParts[1]);

    if (command.StartsWith("Add"))
    {
        numbers.Add(elementNum);
    }
    else if (command.StartsWith("RemoveAt"))
    {
        numbers.RemoveAt(elementNum);
    }
    else if (command.StartsWith("Remove"))
    {
        numbers.Remove(elementNum);
    }
    else if (command.StartsWith("Insert"))
    {
        int index = int.Parse(commandParts[2]);
        numbers.Insert(index, elementNum);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
