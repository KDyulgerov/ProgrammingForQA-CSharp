namespace _08.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalPieces = width * length;
            int numPieces = 0;
            int piecesNeed = 0;

            while (piecesNeed <= totalPieces)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                { 
                    break;
                }
                numPieces = int.Parse(command);
                piecesNeed += numPieces;

            }
            int diff = Math.Abs(totalPieces - piecesNeed);

            if (totalPieces < piecesNeed)
            {
                Console.WriteLine($"No more cake left! You need {diff} pieces more.");
            }
            else
                Console.WriteLine($"{diff} pieces are left.");
        }
    }
}