namespace _14.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            var peopleInGroup = 0;
            var totalPeople = 0;

            var musala = 0.0;     // 5 people - Musala
            var monblan = 0.0;    // 6 to 12 - Monblan
            var kaliman = 0.0;    // 13 to 25 - Kalimandzharo
            var ktwo = 0.0;       // 26 to 40 - K2
            var everest = 0.0;    // 41 and more - Everest

            int i = 1;

            while (i <= groups)
            {
                peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;
                i++;

                if (peopleInGroup < 6)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    kaliman += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    ktwo += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    everest += peopleInGroup;
                }
            }
            Console.WriteLine($"{musala / totalPeople * 100:F2}%");
            Console.WriteLine($"{monblan / totalPeople * 100:F2}%");
            Console.WriteLine($"{kaliman / totalPeople * 100:F2}%");
            Console.WriteLine($"{ktwo / totalPeople * 100:F2}%");
            Console.WriteLine($"{everest / totalPeople * 100:F2}%");
        }
    }
}