using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {

        Droid[] droidArray = new Droid[100];




        public void GetPrintString(UserInterface ui)
        {
            string outputString = "";
            {
                foreach (Droid droid in droidArray)
                {
                    if (droid != null)
                    {
                        outputString += droid.ToString() +
                            Environment.NewLine;
                    }
                }
            }
            ui.Output(outputString);
        }
    }
}
