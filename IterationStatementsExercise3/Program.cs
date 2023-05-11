using System;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
        }

            //Write a method that will print to the console all numbers 1000 through - 1000

            public static void PrintThousand()
            {
              
                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);

                }

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            ByThrees();

            static void ByThrees()
            {

                for (int k = 3; k <= 999; k += 3)
                {
                    Console.WriteLine(k);

                }
                //Write a method to accept two integers as parameters and check whether they are equal or not


                Console.WriteLine(counterNumbers(3, 7));

                static bool counterNumbers(int a, int b)

                {
                    var check = (a == b) ? true : false;

                    return check;
                }
                //Write a method to check whether a given number is even or odd
                { 
                int number;
                Console.Write("Enter an integer :");
                number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Your number is even.");
                }
                else
                {
                    Console.WriteLine("Your number is odd.");
                }
                Console.ReadKey();
            }

                //Write a method to check whether a given number is positive or negative

                {
                    int num;
                    Console.Write("Enter a number that is positive or negative :");
                    num = Int32.Parse(Console.ReadLine());
                    if (num >=0)
                    {
                        Console.WriteLine("Your number is positive.");
                    }
                    else
                    {
                        Console.WriteLine("Your number is negative.");
                    }
                    Console.ReadKey();
                }

                //Write a method to read the age of a candidate and determine whether they can vote.
                //Hint: Use Parse or the safer TryParse() for an extra challenge
                //Parse()
                //TryParse()

                int Voteage;
                Console.Write("How old are you? :");
                Voteage = Int32.Parse(Console.ReadLine());
                if (Voteage >= 18)
                {
                    Console.WriteLine("You are of age to vote.");
                }
                else
                {
                    Console.WriteLine("You are to young to vote.");
                }
                Console.ReadKey();


                //Heatin Up Section:
                //Write a method to check if an integer(from the user) is in the range -10 to 10

                int InBetween;
                Console.Write("Enter a number :");
                InBetween = Int32.Parse(Console.ReadLine());
                if (InBetween >= -10 && InBetween <= 10)
                {
                    Console.WriteLine("You are in between -10 and 10.");
                }
                else
                {
                    Console.WriteLine("You are not in between -10 and 10.");
                }
                Console.ReadKey();



                //Write a method to display the multiplication table(from 1 to 12) of a given integer


                int x, n;

                Console.Write("\n\n");
                Console.Write("Display the multiplication table:\n");
                Console.Write("-----------------------------------");
                Console.Write("\n\n");

                Console.Write("Input the number (Table to be calculated) : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                for (x = 1; x <= 12; x++)
                {
                    Console.Write("{0} X {1} = {2} \n", n, x, n * x);
                }
            }
        }

    }

        }

        
            
        
    