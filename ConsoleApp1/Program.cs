﻿using System;
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
   
          
        }


    }
}