using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bQuit = false;
            int intChoice;

            do
            {
                Console.WriteLine("Welcome to the Guessing Game!");
                Console.WriteLine("1. Iteration 1");
                Console.WriteLine("2. Iteration 2");
                Console.WriteLine("3. Iteration 3");
                Console.WriteLine("4. Iteration 4");
                Console.WriteLine("5. Iteration 5");
                Console.WriteLine("6. Iteration 6");
                Console.WriteLine("7. Stretch Task");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Type the number of the task you wish to perform:");

                intChoice = Convert.ToInt32(Console.ReadLine());

                switch (intChoice)
                {
                    case 1:
                        IterationOne();
                        break;
                    case 2:
                        IterationTwo();
                        break;
                    case 3:
                        IterationThree();
                        break;
                    case 4:
                        IterationFour();
                        break;
                    case 5:
                        IterationFive();
                        break;
                    case 6:
                        IterationSix();
                        break;
                    case 7:
                        IterationSeven();
                        break;
                    case 0:
                        return;
                }
            } while (bQuit == false);






        }

        static void IterationOne()
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            int intGuess = Convert.ToInt32(Console.ReadLine());

            
            if (intGuess == 7)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose!");
        }

        static void IterationTwo()
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            int intGuess = Convert.ToInt32(Console.ReadLine());


            if (intGuess == 7)
                Console.WriteLine("You win!");
            else if (intGuess == 0)
                Console.WriteLine("Type a whole number from 1 to 10.");
            else
                Console.WriteLine("You lose!");
        }

        static void IterationThree()
        {
            int intRun = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess == 7)
                {
                    Console.WriteLine("You win!");
                    intRun = 2;
                }
                else if (intGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else
                {
                    Console.WriteLine("Try again!");
                    intRun++;
                }

            } while (intRun < 2);
        }

        static void IterationFour()
        {
            int intRun = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess == 7)
                {
                    Console.WriteLine("You win!");
                    intRun = 2;
                }
                else if (intGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (intGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    intRun++;
                }

            } while (intRun < 2);
        }

        static void IterationFive()
        {
            int intRun = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess == 7)
                {
                    Console.WriteLine("You win!");
                    intRun = 2;
                }
                else if (intGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (intGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    intRun++;
                    if (intGuess < 7)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (intRun < 2);
        }

        static void IterationSix()
        {
            Random rRandomNum = new Random();
            int intCorrectNum = rRandomNum.Next(1, 10);

            int intRun = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess == intCorrectNum)
                {
                    Console.WriteLine("You win!");
                    intRun = 2;
                }
                else if (intGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (intGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    intRun++;
                    if (intGuess < intCorrectNum)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (intRun < 2);
        }

        static void IterationSeven()
        {
            Random rRandomNum = new Random();
            int intCorrectNum = rRandomNum.Next(1, 10);

            int intRun = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int intGuess = Convert.ToInt32(Console.ReadLine());

                if (intGuess == intCorrectNum)
                {
                    Console.WriteLine("You win!");
                    intRun = 2;
                }
                else if (intGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (intGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    intRun++;
                    if (intGuess < intCorrectNum)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (intRun < 3);
        }

    }
}