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
            public DateTime DoB { get; set; }
            public string Town { get; set; }
            public string Good { get; set; }
            public string Gender { get; set; }
        }



        static void Main(string[] args)
        {
            var profile1 = new profile();
            profile1.name = GetProfileName();
            profile1.Town = GetProfileTown();
            profile1.Good = GetProfileGood();
            profile1.DoB = GetProfileDoB();
            profile1.Gender = GetProfileGender();
            DisplayProfile(profile1);
          
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();


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
        private static DateTime GetProfileDoB()
        {
            while (true)
            {
                WriteLine("Please enter your date of Birth in the format 'DD/MM/YYYY'");

                string YourProfileDoB = ReadLine();

                DateTime Dob = DateTime.ParseExact(YourProfileDoB, "dd/MM/yyyy", null);
                return Dob;
            }

        }

        private static string GetProfileGood()
        {
            while (true)
            {
                WriteLine("Have you been good or bad?");

                string YourProfileGood = ReadLine();

                if (YourProfileGood != "good" && YourProfileGood != "bad")
                {
                    WriteLine("ERROR - please enter 'good' or 'bad'!");
                }
                else
                {
                    return YourProfileGood;
                }
            }

        }
        private static string GetProfileGender()
        {
            while (true)
            {
                WriteLine("Are you a girl or a boy?");

                string YourProfileGender = ReadLine();

                if (YourProfileGender != "girl" && YourProfileGender != "boy")
                {
                    WriteLine("ERROR - please enter 'girl' or 'boy'!");
                }
                else
                {
                    return YourProfileGender;
                }
            }

        }



        private static void DisplayProfile(profile p)
        {
            WriteLine("Profile Details:");
            WriteLine("Hello, " + p.name + ", Ho Ho Ho!");
            WriteLine("I bet it's cold up in " + p.Town);
            WriteLine("I see you've been a " + p.Good + " " + p.Gender + " this year!");
            WriteLine();
            WriteLine("Have a belting Christmas. Love, Santa!");
        }
    }
}
