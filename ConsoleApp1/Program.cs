using System;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        //---------- FUNCTIONS ---------

        static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0}: {1}", i, message);
            }
        }

        //---------- END OF FUNCTIONS ---------

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // ARRAYS
            int[] favNumbers = new int[3];
            favNumbers[0] = 21;
            favNumbers[1] = 10;
            favNumbers[2] = 1988;
            Console.WriteLine(favNumbers);

            Console.WriteLine();

            int[] randomArr = { 1, 12, 2, 44, 20, 1988 };
            PrintArray(randomArr, "forEach");

          
        }


    }
}