int[] inputArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

double result = AverageOfMiddleElements(inputArray);

Console.WriteLine($"{result:F2}");

static double AverageOfMiddleElements(int[] Array)
{
    int middleDigit = Array.Length / 2;

    double average = (Array[middleDigit] + Array[middleDigit - 1]) / 2.0;

    return average;
}