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

            string[] customersNames = { "Bob", "Sally", "Daniel" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomObject = { "Paul", 45, 12.12345 };

            Console.WriteLine("random array: {0}", randomObject[0].GetType());
            Console.WriteLine("random array: {0}", randomObject[1].GetType());
            Console.WriteLine("random array: {0}", randomObject[2].GetType());
            Console.WriteLine("random array length: {0}", randomObject.Length);

            Console.WriteLine();

            for (int i = 0; i < customersNames.Length; i++)
            {
                Console.WriteLine(i + ": " + customersNames[i]);
            }

            Console.WriteLine();

            int[] randomArr = { 1, 2, 12, 21, 1988 };
            PrintArray(randomArr, "forEach");
        }


    }
}