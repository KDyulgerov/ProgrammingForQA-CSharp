static int CalculateRectangleArea(int height, int length)
{
    int area = height * length;
    return area;
}

int height = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int result = CalculateRectangleArea(height, length);

Console.WriteLine(result);


