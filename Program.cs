using Topic_5._5___More_Classes;

namespace _12_Topic_6___Loops
{
    internal class Program
    {
        public static void prompter()
        {
            int minValue = 0, maxValue = 0, betweenValue = 0;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Prompter!");
            Console.WriteLine();
            Console.Write("Please give me a minimum value: ");
            minValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please give me a maximum value: ");
            maxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Now, please give me a whole number between {minValue} and {maxValue}: ");
            betweenValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (minValue <= betweenValue || maxValue >= betweenValue)
            {
                Console.WriteLine($"That number isn't between {minValue} and {maxValue}, you should know that.");
                Console.Write("Try again: ");
                betweenValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine($"Good job! {betweenValue} is between {minValue} and {maxValue}.");
        }

        public static void percentPassing()
        {
            List <int> gradeList = new List <int>();
            int userGradeInput;
            bool done = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to Percent Passing!");
            Console.WriteLine();
            Console.WriteLine("Please input the grades that you would like analyzed. After each number, " +
                "please press Enter. When you are done, please  type 'q' and press Enter.");
            Console.WriteLine();
            while (!done)
            {
                if (Int32.TryParse(Console.ReadLine(), out userGradeInput))
                {
                    userGradeInput = int.Parse(Console.ReadLine());
                    gradeList.Add(userGradeInput);
                }
                else if (!Int32.TryParse(Console.ReadLine(), out userGradeInput))
                {
                    done = true;
                }
            }
            int numOfGrades = gradeList.Count;
            Console.WriteLine($"You entered {numOfGrades} grades.");
            Console.WriteLine("Here are the grades you entered: ");
            for (int i = 0; i < numOfGrades; i++)
            {
                Console.WriteLine(gradeList[i]);
            }
        }
        public static void oddSum()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void randomNumbers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Random generator = new Random();
            
            int minValue, maxValue, randNumber;
            Console.WriteLine("Please enter a minimum and maximum value.");
            Console.Write("Minimum: ");
            minValue = int.Parse(Console.ReadLine());
            Console.Write("Maximum: ");
            maxValue = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 25; i++)
            {
                randNumber = generator.Next(minValue, (maxValue + 1));
                Console.Write($" {randNumber} ");
            }
        }
        public static void diceGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            bool done = false;
            string userPrediction, dieOutcome, playAgain;
            double userBet, userAcctTotal = 100.00;
            int dieRoll1, dieRoll2;
            Die die1 = new Die();
            Die die2 = new Die();


            Console.WriteLine("Welcome to my dice game. You will start out with $100.\n" +
                "\r\nTo play my game, you will roll two dice. To profit you must roll what you bet, for example: " +
                "\nYou bet doubles and roll doubles, you win your bet");
            Console.WriteLine();
            Console.WriteLine("Roll            | Profit\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Doubles       \t| Win/Lose double their bet (2x). Ex. Bet is $5, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Not Doubles  \t| Win/Lose half their bet. Ex. Bet is $10, user wins $5\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Even Sum   \t| Win/Lose their bet. Ex. Bet is $10, user wins $10\r");
            Console.WriteLine("                |\r");
            Console.WriteLine("Odd Sum     \t| Win/Lose their bet. Ex. Bet is $10, user wins $10\r");
            Console.WriteLine();
            while (!done && userAcctTotal > 0)
            {
                Console.Write("How much would you like to bet? ");
                userBet = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                if (userBet > 0 && userBet <= userAcctTotal)
                {
                    Console.WriteLine($"You have bet ${userBet}");
                }
                else if (userBet <= 0 || userBet > userAcctTotal)
                {
                    Console.WriteLine("You have bet an invalid number, so your bet is $0.00");
                    userBet = 0;
                }
                else
                {
                    Console.WriteLine("Your bet was invalid, so your bet is $0.00");
                    userBet = 0;
                }
                Console.Write("What outcome do you predict? Please type your prediction exactly: ");
                userPrediction = Console.ReadLine().ToLower().Trim().Replace(" ", "");
                Console.WriteLine("Now it's time to roll!");
                Console.WriteLine(die1.Roll);
                die1.DrawRoll();
                die1.RollDie();
                dieRoll1 = die1.Roll;
                Console.WriteLine(die2.Roll);
                die2.DrawRoll();
                die2.RollDie();
                dieRoll2 = die2.Roll;

                // Doubles
                if (die1.Roll == die2.Roll)
                {
                    dieOutcome = "doubles";
                    Console.WriteLine("The outcome was doubles");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += (userBet * 2);
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= (userBet * 2);
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Not Doubles
                else if (die1.Roll != die2.Roll)
                {
                    dieOutcome = "notdoubles";
                    Console.WriteLine("The outcome was not doubles");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += (userBet / 2);
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= (userBet / 2);
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Even Sum
                else if (dieRoll1 + dieRoll2 == 2 || dieRoll1 + dieRoll2 == 4 || dieRoll1 + dieRoll2 == 6 || dieRoll1 + dieRoll2 == 8 || dieRoll1 + dieRoll2 == 10 || dieRoll1 + dieRoll2 == 12)
                {
                    dieOutcome = "evensum";
                    Console.WriteLine("The outcome was an even sum");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += userBet;
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= userBet;
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                // Odd Sum
                else if (dieRoll1 + dieRoll2 == 3 || dieRoll1 + dieRoll2 == 5 || dieRoll1 + dieRoll2 == 7 || dieRoll1 + dieRoll2 == 9 || dieRoll1 + dieRoll2 == 11)
                {
                    dieOutcome = "oddsum";
                    Console.WriteLine("The outcome was an odd sum");
                    if (userPrediction == dieOutcome)
                    {
                        userAcctTotal += userBet;
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine($"You have won ${userBet}");
                    }
                    else if (userPrediction != dieOutcome)
                    {
                        userAcctTotal -= userBet;
                        Console.WriteLine("I'm sorry, maybe next time.");
                        Console.WriteLine($"You have lost ${userBet}");
                    }
                }
                Console.WriteLine($"Your new account balance is {userAcctTotal}");
                Console.WriteLine("");
                Console.Write("Would you like to play again? Yes or no: ");
                playAgain = Console.ReadLine().ToLower().Trim().Replace(" ", "");
                if (playAgain == "no")
                {
                    done = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            bool done = false;
            string choice = "";

            while (choice != "q" && done == false)
            {
                Console.Clear();
                Console.WriteLine("Welcome! Please select an option");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - Odd Sum");
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("5 - Dice Game");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1 - Prompter");
                    prompter();
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2 - Percent Passing");
                    percentPassing();
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "3")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 3 - Odd Sum");
                    oddSum();
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "4")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 4 - Random Numbers");
                    randomNumbers();
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "5")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 5 - Dice Game");
                    diceGame();
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "q")
                {
                    // Do quit
                    done = true;
                }
                // Invalid choice
                else if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5" || choice != "q")
                {
                    Console.Write($"Invalid choice, returning to menu ");
                    Thread.Sleep(700);
                    Console.Write(". ");
                    Thread.Sleep(700);
                    Console.Write(". ");
                    Thread.Sleep(700);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}