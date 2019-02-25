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

    }
}
