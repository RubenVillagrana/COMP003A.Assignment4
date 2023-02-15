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
            Console.WriteLine("For each Section");
            Console.WriteLine("Output all of Friends in an array");
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
                //declare integer named counter and assigned a value of 0//
                int Counter = 0;

                do
                {
                //Output the value of the variable counter//
                    Console.WriteLine(Counter);
                    
                //Adding 5 to the counter value//
                    Counter += 5;
                
                //counter is less than or equal to 50//
                } while (Counter <= 50);

                Console.WriteLine("***************************************");
                Console.WriteLine("While Loop Section");
                Console.WriteLine("FooBar");
                Console.WriteLine("****************************************");

                {
                    //declaring an integer named counter 2 and assigning value of 1//
                    int counter2 = 1;
                    
                    //counter 2 is less than or equal to 20//
                    while (counter2 <= 20)

                    {
                     //if counter 2 is divisible by 2 and 5 Foobar will be output//
                        if (counter2 % 2 == 0 && counter2 % 5 == 0)

                        {
                            Console.WriteLine("FooBar");
                        }
                        //if counter 2 is divisible by 2 Foo will output//
                        else if (counter2 % 2 == 0)
                        {
                            Console.WriteLine("Foo");
                        }
                        //if counter 2 is divisible by 5 Bar will output//
                        else if (counter2 % 5 == 0)
                        {
                            Console.WriteLine("Bar");
                        }
                        else
                        {
                            Console.WriteLine(counter2);
                        }
                        //value of counter 2 will increment by 1//
                        counter2++;
                    }

                }
            }
        }
    }
}
    

    




















