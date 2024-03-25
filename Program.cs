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
            Console.WriteLine("Now, please give me a number between the two previous values: ");
            betweenValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (minValue > betweenValue && maxValue < betweenValue)
            {
                Console.WriteLine("That number isn't between the previous values, you should know that.");
                Console.Write("Try again: ");
                betweenValue = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void percentPassing()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

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

        }
        public static void diceGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

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
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2 - Percent Passing");
                    percentPassing();
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 3 - Odd Sum");
                    oddSum();
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 4 - Random Numbers");
                    randomNumbers();
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 5 - Dice Game");
                    diceGame();
                    Console.ReadLine();
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