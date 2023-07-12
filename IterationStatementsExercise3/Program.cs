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
            PauseConsole();

            ByThrees();
            PauseConsole();



            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();

            bool areEqual = EqualChecker(userNum1, userNum2);

            Console.WriteLine($"{userNum1} is equal to {userNum2}: {areEqual}");
            Console.WriteLine("For Next part Press Enter");
            PauseConsole();


            EvenOrOdd();
            PauseConsole();

            PositiveOrNegative();
            PauseConsole();

            voteage();
            PauseConsole();

            Multiplyfrom1to12();
            PauseConsole();


        }
        //Write a method that will print to the console all numbers 1000 through - 1000

        private static void PrintThousand()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("For Next part Press Enter");
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time


        static void ByThrees()
        {

            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);

            }


            Console.WriteLine("For Next part Press Enter");
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        private static int GetUserNumber()
        {
            Console.WriteLine("Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;

        }

        private static bool EqualChecker(int num1, int num2)

        {
            return num1 == num2;

        }
        //Write a method to check whether a given number is even or odd

        private static void EvenOrOdd()
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
            Console.WriteLine("For Next part Press Enter twice");

            Console.ReadKey();

        }

        //Write a method to check whether a given number is positive or negative
        private static void PositiveOrNegative()
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

            Console.WriteLine("For Next part Press Enter twice");
            Console.ReadKey();
                }

        //Heatin Up Section:
        //Write a method to read the age of a candidate and determine whether they can vote.

        private static void voteage()
        {
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
            Console.WriteLine("For Next part Press Enter twice");
        }



        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        private static void Multiplyfrom1to12()
        { 
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


    private static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


    
        

    





