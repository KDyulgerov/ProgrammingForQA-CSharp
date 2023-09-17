namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApart = 0;

            switch(month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApart = 65;
                    if (nights > 7 && nights <=14)
                    {
                        priceStudio *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        priceStudio *= 0.70;
                        priceApart *= 0.90;
                    }
                    break;

                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApart = 68.70;

                    if (nights > 14)
                    {
                        priceStudio *= 0.80;
                        priceApart *= 0.90;
                    }
                    break;
                    
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApart = 77;

                    if (nights > 14)
                    {
                        priceApart *= 0.90;
                    }
                    break;

            
            }
            double apartmentPrice = priceApart * nights;
            double studioPrice = priceStudio * nights;

            Console.WriteLine($" Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($" Studio: {studioPrice:F2} lv.");
        }
    }
}