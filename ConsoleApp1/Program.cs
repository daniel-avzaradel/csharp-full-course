using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("100");
            double doubleFromStr = double.Parse("1.2345");
            string strValue = doubleFromStr.ToString();

            Console.WriteLine("Converted boolean from string: {0}", boolFromString);
            Console.WriteLine("Converted int from string: {0}", intFromString);
            Console.WriteLine(doubleFromStr);
            Console.WriteLine(strValue);

            Console.WriteLine($"Data type: {strValue.GetType()}");
            Console.WriteLine($"Data type: {doubleFromStr.GetType()}");
            Console.WriteLine($"Data type: {intFromString.GetType()}");
            Console.WriteLine($"Data type: {boolFromString.GetType()}");
        }
    }
}