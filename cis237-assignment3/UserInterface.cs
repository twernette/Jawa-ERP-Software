using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UserInterface
    {
        //This method handles the user's decision from the options listed in the main menu.
        public int GetUserInput()
        {
            // Print out a menu
            this.PrintMenu();

            // Get the input from the user
            int caseSwitch;
            int.TryParse(Console.ReadLine(), out caseSwitch);


            // While the input is not valid re-get the input
            while (caseSwitch != 1 && caseSwitch != 2 && caseSwitch != 3 && caseSwitch != 4 && caseSwitch != 5)
            {
                // Print error message
                this.PrintErrorMessage();

                // Re-print the menu
                this.PrintMenu();

                // Get the input from the console again
                caseSwitch = int.Parse(Console.ReadLine());
            }


            // At this point I know the input is a valid number
            // of either a 1/2/3/4.
            return caseSwitch;
        }

        //a simple writeline wrapper for easy calling.
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        //Menu options for program.
        private void PrintMenu()
        {
            Output("What would you like to do?");
            Output("1. Add a New Droid");
            Output("2. Print List of Droids");
            Output("3. ");
            Output("4. ");
            Output("5. Exit");
        }

        //Error message when decision for main menu is invalid.
        private void PrintErrorMessage()
        {
            Output("That is not a valid entry.");
            Output("Please make a valid choice");
            Output("");
        }

        public string GetDroidType()
        {
            Console.WriteLine("Which type of Droid would you like to add?");
            Console.WriteLine("(EX: Protocol, Utility, Astro, Janitor)");
            return Console.ReadLine();
        }

        public string GetDroidMaterial()
        {
            Console.WriteLine("What would you like your droid to be made of?");
            Console.WriteLine("(EX: Wood, Brick, Metal)");
            return Console.ReadLine();
        }

        public string GetDroidColor()
        {
            Console.WriteLine("What color would you like your droid to be?");
            return Console.ReadLine();
        }

        public bool GetDroidToolbox()
        {
            Console.WriteLine("Would you like your utility droid to have a toolbox?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetDroidComputer()
        {
            Console.WriteLine("Would you like your utility droid to have a computer connection?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetDroidArm()
        {
            Console.WriteLine("Would you like your utility droid to have an arm?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetDroidTrash()
        {
            Console.WriteLine("Would you like your janitor droid to have a trash compactor?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetDroidVacuum()
        {
            Console.WriteLine("Would you like your janitor droid to have a vacuum?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetDroidFire()
        {
            Console.WriteLine("Would you like your astro droid to have a fire extinquisher?");
            Console.WriteLine("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetDroidShips()
        {
            Console.WriteLine("How many ships will your astro droid be servicing?");
            return int.Parse(Console.ReadLine());
        }
        public int GetDroidLanguages()
        {
            Console.WriteLine("How many languages should your protocol droid be familiar with?");
            return int.Parse(Console.ReadLine());
        }
    }
}
