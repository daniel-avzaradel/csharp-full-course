using System;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Currency: {0:c}", 23.455);
            Console.WriteLine("Pad With Zeros Currency: {0:d4}", 23);
            Console.WriteLine("3 Decimals Currency: {0:f3}", 23.615253);
            Console.WriteLine("Commas Currency: {0:n4}", 22000);
        }
    }
}