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

            string randomStr = "daniel_avzaradel";
            Console.WriteLine("String Length: {0}", randomStr.Length);
            Console.WriteLine("String Contains is: {0}", randomStr.Contains("ani"));
            Console.WriteLine("Index of 'n' is: {0}", randomStr.IndexOf("n"));

            Console.WriteLine("Uppercase: {0}", randomStr.ToUpper());
            Console.WriteLine("Lowercase: {0}", randomStr.ToLower());
            Console.WriteLine("Pad Left: {0}", randomStr.PadLeft(20, '.'));
            Console.WriteLine("Pad Right: {0}", randomStr.PadRight(20, '.'));
        }
    }
}