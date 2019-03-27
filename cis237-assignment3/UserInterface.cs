using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
    class UserInterface
    {

        //******************
        //Methods
        //******************

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
            // of either a 1/2.
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
            Output("3. Add Generic Droids to List *TEST*");
            Output("4. Sort Droid List by Model");
            Output("5. Exit");
        }

        //Error message when decision for main menu is invalid.
        private void PrintErrorMessage()
        {
            Output("That is not a valid entry.");
            Output("Please make a valid choice");
            Output("");
        }

        //Asks user to specify type of droid to add to inventory.
        public string GetDroidType()
        {
            Output("Which type of Droid would you like to add?");
            Output("(EX: Protocol, Utility, Astro, Janitor)");
            return Console.ReadLine();
        }

        //Asks user to specify the type of material the droid is made out of.
        public string GetDroidMaterial()
        {
            Output("What would you like your droid to be made of?");
            Output("(EX: wood, brick, metal)");
            return Console.ReadLine();
        }

        //Asks user to specify what color the droid is.
        public string GetDroidColor()
        {
            Output("What color would you like your droid to be?");
            return Console.ReadLine();
        }

        //Asks user for a integer value based off of two possible questions asked in the collection class.
        public int GetDroidInt(string outString)
        {
            Output(outString);
            return int.Parse(Console.ReadLine());
        }

        //Asks user for a true/false response that is utilized for all additional features over every class of droid.
        public bool GetDroidBool(string outString)
        {
            Output(outString);
            Output("(Enter true/false)");
            if (Console.ReadLine() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
