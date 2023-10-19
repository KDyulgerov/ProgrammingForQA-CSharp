int repeat = int.Parse(Console.ReadLine());

List <string> products = new List<string>();

for (int i = 1; i <= repeat; i += 1)
{
    string product = Console.ReadLine();
    products.Add(product);

}

products.Sort();
for (int j = 1; j <= repeat; j += 1)
{
    Console.WriteLine($"{j}.{products[j - 1]}");
}

