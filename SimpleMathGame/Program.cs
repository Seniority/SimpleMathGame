using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathGame
{
    /// <summary>
    /// Simple math game that asks math questions using random numbers.
    /// By Anthony Senior II, 10/10/2015
    /// </summary>
    
    class Game
    {
        public static string[] compliments =
            {
                "Great work!",
                "Awesome!",
                "Math champion!",
                "Well done!",
                "Keep it up!",
                "Excellent!"
            };

        static void Main(string[] args)
        {
            Console.Title = "The Math Game";

            int a, b, c, answer, totalScore, addScore, subScore, mulScore, divScore;
            totalScore = 0; //score for entire game
            addScore = 0; //score for the addition section only
            subScore = 0; //score for the subtraction section only
            mulScore = 0; //score for the multiplication section only
            divScore = 0; //score for the division section only
            Random rnd = new Random();

            //game start
            Console.WriteLine("Welcome to The Math Game! I'll give you some simple problems to solve.");
            Console.WriteLine("INSTRUCTIONS: Press ENTER after answering each question to submit your answer and move on to the next question.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to get started!");
            Console.ReadLine();

            //addition questions
            Console.WriteLine("Let's start with some addition problems...");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                a = rnd.Next(0, 101);
                b = rnd.Next(0, 101);
                c = a + b;

                Console.Write("What is {0} + {1}? ", a, b);
                answer = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your answer: {0}", answer);
                Console.Write("The correct answer is {0}! ", c);
                if (answer == c)
                {
                    totalScore++;
                    addScore++;
                    Console.WriteLine(compliments[rnd.Next(0, compliments.Length)]);
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Press ENTER to move on to some subtraction exercises.");
            Console.ReadLine();

            //subtraction questions
            for (int i = 0; i < 5; i++)
            {
                a = rnd.Next(0, 101);
                b = rnd.Next(0, 101);
                c = a - b;

                Console.Write("What is {0} - {1}? ", a, b);
                answer = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your answer: {0}", answer);
                Console.Write("The correct answer is {0}! ", c);
                if (answer == c)
                {
                    totalScore++;
                    subScore++;
                    Console.WriteLine(compliments[rnd.Next(0, compliments.Length)]);
                }

                Console.WriteLine();
                Console.WriteLine();

            }
            
            //multiplication questions            
            Console.WriteLine("Press ENTER to proceed to some really advanced stuff... Multiplication!");
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                a = rnd.Next(0, 21);
                b = rnd.Next(0, 11);
                c = a * b;

                Console.Write("What is {0} * {1}? ", a, b);
                answer = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your answer: {0}", answer);
                Console.Write("The correct answer is {0}! ", c);
                if (answer == c)
                {
                    totalScore++;
                    mulScore++;
                    Console.WriteLine(compliments[rnd.Next(0, compliments.Length)]);
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            //division questions
            Console.WriteLine("Press ENTER to finish the game with some division!");
            Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                a = rnd.Next(0, 51);
                b = rnd.Next(0, 13);
                c = a * b;

                Console.Write("What is {0} / {1}? ", c, a);
                answer = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your answer: {0}", answer);
                Console.Write("The correct answer is {0}! ", b);
                if (answer == b)
                {
                    totalScore++;
                    divScore++;
                    Console.WriteLine(compliments[rnd.Next(0, compliments.Length)]);
                }


                Console.WriteLine();
                Console.WriteLine();
            }           

            //postgame summary
            Console.WriteLine("You have successfully completed the game! Press ENTER to get your post-game summary.");
            Console.ReadLine();
            Console.WriteLine("Here is your post-game summary:");

            //addition scoring
            Console.Write("Addition: You got {0} out of 5 correct. ", addScore);
            switch (addScore)
            {
                case 5:
                    Console.WriteLine("You did excellent! Someone was paying attention in class.");
                    break;
                case 4:
                    Console.WriteLine("Great work! Your addition skills seems to be pretty good.");
                    break;
                case 3:
                    Console.WriteLine("Looks like your addition skills can use some work. Keep practicing and you will be a master!");
                    break;
                case 2:
                    Console.WriteLine("Your addition skills need work! Consider getting a tutor and spending extra time studying.");
                    break;
                case 1:
                    Console.WriteLine("Your addition skills are in serious trouble. Talk to a someone about extra help so that you do not fall behind!");
                    break;
                case 0:
                    Console.WriteLine("Look into registering for a basic math course.");
                    break;
                default:
                    Console.WriteLine("An error with the scoring occured!");
                    break;
            }


            //subtraction scoring
            Console.Write("Subtraction: You got {0} out of 5 correct. ", subScore);
            switch (subScore)
            {
                case 5:
                    Console.WriteLine("You did excellent! Someone was paying attention in class.");
                    break;
                case 4:
                    Console.WriteLine("Great work! Your subtraction skills seems to be pretty good.");
                    break;
                case 3:
                    Console.WriteLine("Looks like your subtraction skills can use some work. Keep practicing and you will be a master!");
                    break;
                case 2:
                    Console.WriteLine("Your subtraction skills need work! Consider getting a tutor and spending extra time studying.");
                    break;
                case 1:
                    Console.WriteLine("Your subtraction skills are in serious trouble. Talk to a someone about extra help so that you do not fall behind!");
                    break;
                case 0:
                    Console.WriteLine("Look into registering for a basic math course.");
                    break;
                default:
                    Console.WriteLine("An error with the scoring occured!");
                    break;
            }

        
            //multiplication scoring
            Console.Write("Multiplication: You got {0} out of 5 correct. ", mulScore);
            switch (mulScore)
            {
                case 5:
                    Console.WriteLine("You did excellent! Someone was paying attention in class.");
                    break;
                case 4:
                    Console.WriteLine("Great work! Your multiplication skills seems to be pretty good.");
                    break;
                case 3:
                    Console.WriteLine("Looks like your multiplication skills can use some work. Keep practicing and you will be a master!");
                    break;
                case 2:
                    Console.WriteLine("Your multiplication skills need work! Consider getting a tutor and spending extra time studying.");
                    break;
                case 1:
                    Console.WriteLine("Your multiplication skills are in serious trouble. Talk to a someone about extra help so that you do not fall behind!");
                    break;
                case 0:
                    Console.WriteLine("Look into registering for a basic math course.");
                    break;
                default:
                    Console.WriteLine("An error with the scoring occured!");
                    break;
            }

            //division scoring
            Console.Write("Division: You got {0} out of 5 correct. ", divScore);
            switch (divScore)
            {
                case 5:
                    Console.WriteLine("You did excellent! Someone was paying attention in class.");
                    break;
                case 4:
                    Console.WriteLine("Great work! Your division skills seems to be pretty good.");
                    break;
                case 3:
                    Console.WriteLine("Looks like your division skills can use some work. Keep practicing and you will be a master!");
                    break;
                case 2:
                    Console.WriteLine("Your division skills need work! Consider getting a tutor and spending extra time studying.");
                    break;
                case 1:
                    Console.WriteLine("Your division skills are in serious trouble. Talk to a someone about extra help so that you do not fall behind!");
                    break;
                case 0:
                    Console.WriteLine("Look into registering for a basic math course.");
                    break;
                default:
                    Console.WriteLine("An error with the scoring occured!");
                    break;
            }

            Console.WriteLine();

            //Total scoring
            Console.Write("Total Game Score: {0} correct out of 20. ", totalScore);
            if (totalScore == 20)
            {
                Console.WriteLine("You got a perfect score! You are a math genius.");
            }

            
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press ENTER to exit the application.");
            Console.ReadLine();
        }// end Main
    }// end Class
}// end Namespace
