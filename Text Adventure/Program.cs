using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Program
    {
        public static string userName;

        static void Main(string[] args)
        {
            //String to hold the user options
            string userOptions = "";
            Console.WriteLine("Welcome!");
            //Insert blank line
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            //waits for user to press a keyboard key to continue running the program
            Console.ReadKey();
            //Clears the console window to free up space on the screen
            Console.Clear();
            Console.WriteLine("You wake up with a headache, confused and surrounded with empty red solo cups and chips.");
            Console.WriteLine();
            //Options
            Console.WriteLine("[1] Get up");
            Console.WriteLine("[2] Fall back asleep");
            Console.WriteLine();
            Console.WriteLine("Enter selection:");
            userOptions = Option1(userOptions);
        }

        static string Option1(string userOptions)
        {
            userOptions = Console.ReadLine();
            if (userOptions == "1")
            {
                Console.Clear();
                Console.WriteLine("You decide to get up");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Unkown: Ah! There you are! Time to clean up this mess! ");
                Console.WriteLine("Here's a garbage bag, meet you in the kitchen in 30 minutes!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You get up, pick up the bag and remember your name (Enter It!)");
                userName = playerName(userName);
                Console.WriteLine("You remember your name is " + userName);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                userOptions = Kitchen(userOptions);
                userOptions = Option2(userOptions);
            }
            else if (userOptions == "2")
            {
                Console.Clear();
                Console.WriteLine("You decide to fall back asleep");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The End");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid");
                userOptions = Option1(userOptions);
            }

            return userOptions;
        }

        static string Option2(string userOptions)
        {
            userOptions = Console.ReadLine();
            if (userOptions == "1")
            {
                Console.Clear();
                Console.WriteLine("You decide to pick up the garbage");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("After you pick up all the trash you walk into the kitchen");
                Console.WriteLine();
                Console.WriteLine("(You find your mom cleaning the dishes)");
                Console.WriteLine();
                Console.WriteLine(userName + ", finally! So you cleaned up everything! Great! Now we're ready for the New Year's party!");
                Console.WriteLine();
                Console.WriteLine("What Will you do?");
                Console.WriteLine();
                Console.WriteLine("[1] Collapse and wake up when the Holidays are over");
                userOptions = Option3(userOptions);

            }
            else if (userOptions == "2")
            {
                Console.Clear();
                Console.WriteLine("You walk into the kitchen, your mom is cleaning up dishes.");
                Console.WriteLine();
                Console.WriteLine(userName + "! What are you doing here? I told you to clean up! Come back when you're done!");
                Console.WriteLine();
                Console.WriteLine("[1] Go back to Living Room");
                userOptions = Kitchen(userOptions);


            }
            else
            {
                Console.WriteLine("Invalid");
                userOptions = Option1(userOptions);
            }

            return userOptions;
        }


        static string Option3(string userOptions)
        {
            userOptions = Console.ReadLine();
            if (userOptions == "1")
            {
                Console.Clear();
                Console.WriteLine("You Collapse on the floor and sleep till the holidays are over");
                Console.WriteLine();
                Console.WriteLine("The End");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid");
                userOptions = Option1(userOptions);
            }

            return userOptions;
        }

        static string Kitchen(string userOptions)
        {

            Console.WriteLine("What Will you do?");
            Console.WriteLine();
            Console.WriteLine("[1] Pick up the empty cups and chips");
            Console.WriteLine("[2] Go to the Kitchen");

            return userOptions;
        }

        static string playerName(string userName)
        {
            userName = Console.ReadLine();
            if (String.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Invalid");
                Console.ReadLine();
                userName = playerName(userName);

            }
            else
            {
                userName = playerName(userName);
            }
            return userName;
        }

        }
    }
