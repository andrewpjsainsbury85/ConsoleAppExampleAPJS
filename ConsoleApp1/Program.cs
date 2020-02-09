using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {

        class profile
        {
         
            public string name { get; set; }
            //public DateTime DoB { get; set; }
            public string Town { get; set; }
        }



        static void Main(string[] args)
        {
            var profile1 = new profile();
            profile1.name = GetProfileName();
            //profile1.DoB = GetProfileDoB();
            profile1.Town = GetProfileTown();
            DisplayProfile(profile1);
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static string GetProfileName()
        {
            while (true)
            {
                WriteLine("Please enter your name");

                string YourProfileName = ReadLine();

                if (string.IsNullOrWhiteSpace(YourProfileName))
                {
                    WriteLine("ERROR - Put a first name!");
                }
                else
                {
                    return YourProfileName;
                }
            }

        }

        private static string GetProfileTown()
        {
            while (true)
            {
                WriteLine("Please enter your town");

                string YourProfileTown = ReadLine();

                if (string.IsNullOrWhiteSpace(YourProfileTown))
                {
                    WriteLine("ERROR - Put a town!");
                }
                else
                {
                    return YourProfileTown;
                }
            }

        }

        //private static DateTime GetProfileDoB()
        //{
        //    while (true)
        //    {
        //        WriteLine("Please enter your DOB in the format YYYY.MM.DD");

        //        DateTime YourProfileDoB = ReadLine();

        //        if()
        //    }
        //}

        private static void DisplayProfile(profile p)
        {
            WriteLine("Profile Details...");
            WriteLine("Your Name is " + p.name);
            WriteLine("Your Town is " + p.Town);
        }
    }
}
