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
            Console.WriteLine("****************************************");

            Console.Write("Enter a positive whole number: ");
            
            //integer named limit and convert response to integer// 
            int limit = Convert.ToInt32(Console.ReadLine());
            
            //sting variable named output assigned value of # //
            string output = "#";

            /*looping variable named i with value of 0
             * loop as long as i is than or equal to 
             * variable limit, increment i by 1
             */
            for (int i = 0; i <= limit; i++)
            {
                //output the value of the the variable output//
                Console.WriteLine(output);
               
                //concatenate the current value of output with #//
                output += "#";
            }

            Console.ReadLine();


            Console.WriteLine("******************************************");
            Console.WriteLine("for each Section");
            Console.WriteLine("output all of Friends in an array");
            Console.WriteLine("*******************************************");

            //Array//
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

           //For each statement that enumerates each friend in friends//
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);


            Console.WriteLine("******************************************");
            Console.WriteLine("Do While Loop");
            Console.WriteLine("Counting by 5");
            Console.WriteLine("*********************************************");

            {
                int Counter = 0;

                do
                {
                    Console.WriteLine(Counter);
                    Counter += 5;
                } while (Counter <= 50);

                Console.WriteLine("***************************************");
                Console.WriteLine("While Loop Section");
                Console.WriteLine("FooBar");

                {
                    int counter2 = 1;
                    while (counter2 <= 100)

                    {
                        if (counter2 % 2 == 0 && counter2 % 5 == 0)

                        {
                            Console.WriteLine("FooBar");
                        }
                        else if (counter2 % 2 == 0)
                        {
                            Console.WriteLine("Foo");
                        }
                        else if (counter2 % 5 == 0)
                        {
                            Console.WriteLine("Bar");
                        }
                        else
                        {
                            Console.WriteLine(counter2);
                        }

                        counter2++;
                    }

                }
            }
        }
    }
}
    

    




















