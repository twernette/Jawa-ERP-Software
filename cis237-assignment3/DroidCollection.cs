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

        public void AddNewDroid(UserInterface ui)
        {
            int i = 0;

            while (i < 100)
            {

                if (droidArray[i] == null)
                {
                    switch (ui.GetDroidType())
                    {

                        case "Protocol":
                            string material = ui.GetDroidMaterial();
                            string color = ui.GetDroidColor();
                            int lang = ui.GetDroidInt("How many languages should your protocol droid be familiar with?");
                            droidArray[i] = new ProtocolDroid(material, color, lang);
                            i = 100;
                            break;

                        case "Utility":
                            material = ui.GetDroidMaterial();
                            color = ui.GetDroidColor();
                            bool toolbox = ui.GetDroidBool("Would you like your utility droid to have a toolbox?");
                            bool computer = ui.GetDroidBool("Would you like your utility droid to have a computer connection?");
                            bool arm = ui.GetDroidBool("Would you like your utility droid to have an arm ? ");
                            droidArray[i] = new UtilityDroid(material, color, toolbox, computer, arm);
                            i = 100;
                            break;

                        case "Astro":
                            material = ui.GetDroidMaterial();
                            color = ui.GetDroidColor();
                            toolbox = ui.GetDroidBool("Would you like your astro droid to have a toolbox?");
                            computer = ui.GetDroidBool("Would you like your astro droid to have a computer connection?");
                            arm = ui.GetDroidBool("Would you like your astro droid to have an arm ? ");
                            bool fire = ui.GetDroidBool("Would you like your astro droid to have a fire extinquisher?");
                            int ships = ui.GetDroidInt("How many ships will your astro droid be servicing ? ");
                            droidArray[i] = new AstroDroid(material, color, toolbox, computer, arm, fire, ships);
                            i = 100;
                            break;

                        case "Janitor":
                            material = ui.GetDroidMaterial();
                            color = ui.GetDroidColor();
                            toolbox = ui.GetDroidBool("Would you like your janitor droid to have a toolbox?");
                            computer = ui.GetDroidBool("Would you like your janitor droid to have a computer connection?");
                            arm = ui.GetDroidBool("Would you like your janitor droid to have an arm ? ");
                            bool trash = ui.GetDroidBool("Would you like your janitor droid to have a trash compactor?");
                            bool vacuum = ui.GetDroidBool("Would you like your janitor droid to have a vacuum ?");
                            droidArray[i] = new JanitorDroid(material, color, toolbox, computer, arm, trash, vacuum);
                            i = 100;
                            break;
                    }
                }
                else
                {
                    i += 1;
                }
            }
        }
    }
}
