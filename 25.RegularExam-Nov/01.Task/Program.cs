int countStudents = int.Parse(Console.ReadLine());

double sum = 0.0;

for (int i = 1; i <= countStudents; i++)
{
    double studentGrade = double.Parse(Console.ReadLine());
    sum += studentGrade;
}

double average = sum / countStudents;

Console.WriteLine($"{average:F2}");