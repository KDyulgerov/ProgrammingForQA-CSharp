namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var floors = int.Parse(Console.ReadLine()); // 6
            var aparts = int.Parse(Console.ReadLine()); // 4

            for (int row = floors; row >= 1; row -= 1)
            {
                for (int col = 0; col < aparts; col += 1)
                {
                    string type = "";
                    if (row == floors)
                    {
                        type = "L";
                    }
                    else if (row % 2 == 0)
                    {
                        type = "O";
                    }
                    else
                    {
                        type = "A";
                    }
                    Console.Write($"{type}{row}{col} ");
                }

                Console.WriteLine();
            }
        }
    }
}