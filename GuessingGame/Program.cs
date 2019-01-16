using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

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

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
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
            } while (quit == false);
                                                  
        }

        static void IterationOne()
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            
            if (userGuess == 7)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose!");
        }

        static void IterationTwo()
        {
            Console.WriteLine("Guess a number between 1 and 10.");
            int userGuess = Convert.ToInt32(Console.ReadLine());


            if (userGuess == 7)
                Console.WriteLine("You win!");
            else if (userGuess == 0)
                Console.WriteLine("Type a whole number from 1 to 10.");
            else
                Console.WriteLine("You lose!");
        }

        static void IterationThree()
        {
            int countTry = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == 7)
                {
                    Console.WriteLine("You win!");
                    countTry = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else
                {
                    Console.WriteLine("Try again!");
                    countTry++;
                }

            } while (countTry < 2);
        }

        static void IterationFour()
        {
            int countTry = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == 7)
                {
                    Console.WriteLine("You win!");
                    countTry = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (userGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    countTry++;
                }

            } while (countTry < 2);
        }

        static void IterationFive()
        {
            int countTry = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == 7)
                {
                    Console.WriteLine("You win!");
                    countTry = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (userGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    countTry++;
                    if (userGuess < 7)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (countTry < 2);
        }

        static void IterationSix()
        {
            Random randomNum = new Random();
            int correctNum = randomNum.Next(1, 10);

            int countTry = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == correctNum)
                {
                    Console.WriteLine("You win!");
                    countTry = 2;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (userGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    countTry++;
                    if (userGuess < correctNum)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (countTry < 2);
        }

        static void IterationSeven()
        {
            Random randomNum = new Random();
            int correctNum = randomNum.Next(1, 10);

            int countTry = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == correctNum)
                {
                    Console.WriteLine("You win!");
                    countTry = 3;
                }
                else if (userGuess == 0)
                {
                    Console.WriteLine("Type a whole number from 1 to 10.");
                }
                else if (userGuess == -1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    countTry++;
                    if (userGuess < correctNum)
                        Console.WriteLine("The answer is higher than you thought...");
                    else
                        Console.WriteLine("The answer is lower than you thought...");
                }

            } while (countTry < 3);
        }

    }
}