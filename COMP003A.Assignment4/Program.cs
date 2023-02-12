/*
 * Author: Ruben Villagrana
 * Course: COMP-003A
 * Purpose: Assignment 4 Code
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClearConsole

{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("For Loop Section");
            Console.WriteLine("Output a right triangle on user Input");





            Console.WriteLine("******************************************");
            Console.WriteLine("for each Section");
            Console.WriteLine("output all of Friends in an array");
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };


            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);


            Console.WriteLine("******************************************");
            Console.WriteLine("Do While Loop");
            Console.WriteLine("Counting by 5");

            {
                int Counter = 0;

                do
                {
                    Console.WriteLine(Counter);
                    Counter += 5;
                } while (Counter <= 50);
            }
        }
    }
}
    




















