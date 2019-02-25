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
                            int lang = ui.GetDroidLanguages();
                            droidArray[i] = new ProtocolDroid(material, color, lang);
                            i = 100;
                            break;

                        case "Utility":
                             material = ui.GetDroidMaterial();
                             color = ui.GetDroidColor();
                            bool toolbox = ui.GetDroidToolbox();
                            bool computer = ui.GetDroidComputer();
                            bool arm = ui.GetDroidArm();
                            droidArray[i] = new UtilityDroid(material, color, toolbox, computer, arm);
                            i = 100;
                            break;

                        case "Astro":
                            material = ui.GetDroidMaterial();
                            color = ui.GetDroidColor();
                            toolbox = ui.GetDroidToolbox();
                            computer = ui.GetDroidComputer();
                            arm = ui.GetDroidArm();
                            bool fire = ui.GetDroidFire();
                            int ships = ui.GetDroidShips();
                            droidArray[i] = new AstroDroid(material, color, toolbox, computer, arm, fire, ships);
                            i = 100;
                            break;

                        case "Janitor":
                            material = ui.GetDroidMaterial();
                            color = ui.GetDroidColor();
                            toolbox = ui.GetDroidToolbox();
                            computer = ui.GetDroidComputer();
                            arm = ui.GetDroidArm();
                            bool trash = ui.GetDroidTrash();
                            bool vacuum = ui.GetDroidVacuum();
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
