namespace _12.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var openTabs = int.Parse(Console.ReadLine());
            var salary = int.Parse(Console.ReadLine());

            string currentSite = "";

            int i = 1;
            while (salary > 0 && i <= openTabs) 
            {
                currentSite = Console.ReadLine();
                i++;

                if (currentSite == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentSite == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentSite == "Reddit")
                {
                    salary -= 50;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine($"{salary:F0}");
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
            
        }
    }
}