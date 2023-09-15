namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double volumeLiters = volume * 0.001;
            double requiredLiters = volumeLiters * ((100 - percentage) / 100);

            Console.WriteLine($"{requiredLiters:F2}");

        }
    }
}