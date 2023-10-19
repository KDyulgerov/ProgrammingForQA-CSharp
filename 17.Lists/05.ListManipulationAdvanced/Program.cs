
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    if (commandParts[0] == "Contains")
    {
        if (numbers.Contains(int.Parse(commandParts[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandParts[0] == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }
    else if (commandParts[0] == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandParts[0] == "GetSum")
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
    else if (commandParts[0] == "Filter")
    {
        int numberToCompare = int.Parse(commandParts[2]);

        switch (commandParts[1])
        {

            case "<":
            {
                foreach (int number in numbers)
                {
                    if (number < numberToCompare)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                    break;
            }
            case ">":
            {
                foreach (int number in numbers)
                {
                    if (number > numberToCompare)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                    break;
            }
            case ">=":
            {
                foreach (int number in numbers)
                {
                    if (number >= numberToCompare)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                    break;
            }
            case "<=":
            {
                foreach (int number in numbers)
                {
                    if (number <= numberToCompare)
                    {
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
                    break;
            }
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));