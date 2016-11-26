using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Program
    {       
        static void Main(string[] args)
        {    
            //String to hold the user options
            string userOptions = "";

            Console.WriteLine("Welcome!");
            //Insert blank line
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            //waits for user to press a keyboard key to continue running the program
            Console.ReadKey();
            //Clears the console window to free up space on the screen
            Console.Clear();
            Console.WriteLine("You wake up with a headache, confused and surrounded with empty red solo cups and chips.");
            Console.WriteLine();
            Console.WriteLine("[1] Get up");
            Console.WriteLine("[2] Fall back asleep");
            Console.WriteLine();
            Console.WriteLine("Enter your selection:");
            userOptions = Option1(userOptions);


        }

        static string Option1(string userOptions)
        {
            userOptions = Console.ReadLine();
            if (userOptions == "1")
            {
                Console.Clear();
                Console.WriteLine("You get up");
                Console.WriteLine();
                Console.WriteLine("");  
            }
            else if (userOptions == "2")
            {
                Console.Clear();
                Console.WriteLine("You decide to fall back asleep");
            }

            return userOptions;
        }
    }
}
