using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine($"Hello {name}");
        }
    }
}