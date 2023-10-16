namespace _22.HelloNamem

{   using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintName(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            string nameUser = Console.ReadLine();

            PrintName(nameUser);

        }
    }
}