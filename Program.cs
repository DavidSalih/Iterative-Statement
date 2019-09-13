/*
 Author: David Salih
 Date: 9/12/2019
 Description: Iterative Statement assignment
 */

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any number from 1 to 100");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 0) && (value_of_input <= 100))
                {
                    // the loop we used in class example in Tuesday
                    for (int i = 0; i <= value_of_input; i++)
                    {
                        Console.WriteLine("Typed" + value_of_input.ToString() + "integer in loop" + i.ToString());
                    }

                    Console.WriteLine("Press ESC twice to exit");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("your numbers only from 1 to 100");
                    Console.WriteLine("Press ESC to leave");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("values shall be numbers from 0 to 100 only");
                Console.WriteLine("Press ESC to leave");
                Console.ReadKey(true);
            }
        }
    }
}
