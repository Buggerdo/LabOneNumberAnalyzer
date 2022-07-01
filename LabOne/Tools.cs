using static System.Console;

namespace LabOne
{
    internal class Tools
    {

        /// <summary>
        /// Gets the users name
        /// </summary>
        /// <returns>Users name Defaults to "Player"</returns>
        public static string GetName()
        {
            Write("Would you like to enter your name Y/N ?");
            string enterName = ReadLine().ToLower().Trim();

            if(enterName == "yes" || enterName == "y")
            {
                Clear();
                Write("Please enter you name: ");
                return ReadLine();
            }
            else
            {
                return "Player";
            }

        }


        /// <summary>
        /// Gets number from the user
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Number entered by the user between 1 and 100</returns>
        public static int GetNumber(string name)
        {
            int number;
            bool isGood = false;
            do
            {
                Clear();
                if(isGood)
                {
                    WriteLine("Please enter a valid number");
                    Thread.Sleep(2000);
                    Clear();
                }
                WriteLine($"{name} please enter a number between 1 and 100");
                isGood = !int.TryParse(ReadLine().Trim(), out number) || number < 1 || number > 100;
            } while(isGood);
            return number;
        }

        /// <summary>
        /// Prints out the response based on the user input
        /// </summary>
        /// <param name="number"></param>
        public static void PrintOut(int number)
        {
            Clear();
            Write($"{number} is ");
            if(number % 2 == 0)
            {
                Write("even and ");
                if(number >= 2 && number < 25)
                {
                    WriteLine("less than 25.");
                }              
                else if(number > 25 && number <= 60)
                {              
                    WriteLine("between 26 and 60 inclusive.");
                }              
                else if(number >= 60)
                {              
                    WriteLine("greater than 60.");
                }
            }
            else
            {
                Write("odd and ");
                if(number > 60)
                {
                    WriteLine("greater than 60.");
                }
                else if(number < 60)
                {
                    WriteLine("less the 60");
                }
            }
        }

        /// <summary>
        /// Checks to see if user wants to continue
        /// </summary>
        /// <returns>True if user wants to continue</returns>
        public static bool TryAgain()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Would you like to continue (Y/N)? ");
                string awnser = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid answer");
                    Thread.Sleep(2000);
                }
            } while(true);
        }

        /// <summary>
        /// Thanks the user and exits the program
        /// </summary>
        /// <param name="name"></param>
        public static void Exit(string name)
        {
            Clear();
            WriteLine($"Thank you for playing {name}");
            Thread.Sleep(2000);
            Clear();
            WriteLine("Press any key to continue");
            ReadKey();
            Environment.Exit(0);
        }

    }
}
