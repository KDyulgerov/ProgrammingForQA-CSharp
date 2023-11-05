List<int> listInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int rotation = int.Parse(Console.ReadLine());

for (int i = 1; i <= rotation; i++)
{
    listInput.Insert(0, listInput[listInput.Count - 1]);
    listInput.RemoveAt(listInput.Count - 1);
}

Console.WriteLine(string.Join(", ", listInput));