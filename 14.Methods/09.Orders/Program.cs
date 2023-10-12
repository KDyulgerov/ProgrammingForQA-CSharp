static void TypeAndPriceOfProduct(string product, int quantity)
{
    double price = 0;
    switch (product)
    {
        case "coffee":
        {
            price = 1.50;
            break;
        }
        case "water":
        {
            price = 1.00;
            break;
        }
        case "coke":
        {
            price = 1.40;
            break;
        }
        case "snacks":
        {
            price = 2.00;
            break;
        }
    }

    Console.WriteLine($"{quantity * price:F2}");
}

string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

TypeAndPriceOfProduct(product, quantity);