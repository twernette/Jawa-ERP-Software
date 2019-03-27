using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
    class Program
    {
        static void Main(string[] args)
        {

            UserInterface ui = new UserInterface();
            DroidCollection collection = new DroidCollection();

            int choice = ui.GetUserInput();

            while (choice != 5)
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
                    case 3:
                        {
                            collection.AddManyDroids();
                            choice = ui.GetUserInput();
                            break;
                        }
                    case 4:
                        {
                            collection.ModifiedBucketSort();
                            choice = ui.GetUserInput();
                            break;
                        }
                }
            }
        }
    }
}