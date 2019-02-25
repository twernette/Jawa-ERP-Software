using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            UserInterface ui = new UserInterface();
            DroidCollection collection = new DroidCollection();

            int choice = ui.GetUserInput();

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        {
                            collection.AddNewDroid(ui);
                            choice = ui.GetUserInput();
                            break;
                        }
                    case 2:
                        {
                            collection.GetPrintString(ui);
                            choice = ui.GetUserInput();
                            break;
                        }
                }
            }
        }
    }
}