using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
    class DroidCollection
    {

        Droid[] droidArray = new Droid[100];



        //GetPrintString is a simple loop that creates an output string with every droid in the array concat'd together.
        public void GetPrintString(UserInterface ui)
        {
            string outputString = "";
            {
                foreach (Droid droid in droidArray)
                {
                    if (droid != null)
                    {
                        outputString += droid.ToString();
                    }
                }
            }
            ui.Output(outputString);
        }

        //this method generates 8 droids and adds them to our droidArray for an easier time testing our sort methods below.
        public void AddManyDroids()
        {
            if (droidArray[0] == null)
            {
                droidArray[0] = new JanitorDroid("wood", "white", true, true, false, true, true);
                droidArray[1] = new ProtocolDroid("wood", "red", 3);
                droidArray[2] = new AstroDroid("metal", "black", true, true, false, true, 3);
                droidArray[3] = new UtilityDroid("metal", "white", true, true, true);
                droidArray[4] = new ProtocolDroid("brick", "blue", 2);
                droidArray[5] = new AstroDroid("wood", "purple", true, false, true, true, 4);
                droidArray[6] = new JanitorDroid("brick", "red", true, false, false, true, false);
                droidArray[7] = new UtilityDroid("metal", "orange", false, false, true);
            }
            else
            {
                Console.WriteLine("No droids added to list, as some droids are already listed in inventory");
            }
        }

        //this modified bucket sort creates a new instance of our stack class for each type of droid in our droidArray.
        //We loop through our array and assign each droid to a stack based on the type of droid.
        //After the droids are divided into sepearte stacks, we add them one at a time to a Queue.
        //Once every droid from each separate stack makes it's way into the queue, we dequeue them back into the original array - now sorted by type.
        public void ModifiedBucketSort()
        {
            GenericStack<Droid> stackJD = new GenericStack<Droid>();
            GenericStack<Droid> stackPD = new GenericStack<Droid>();
            GenericStack<Droid> stackUD = new GenericStack<Droid>();
            GenericStack<Droid> stackAD = new GenericStack<Droid>();
            for (int k = 0; k < 100; k++)
            {
                Droid myDroid = droidArray[k];
                if (myDroid != null)
                {
                    if (myDroid.GetType() == typeof(JanitorDroid))
                    {
                        stackJD.Push(droidArray[k]);
                    }
                    else if (myDroid.GetType() == typeof(ProtocolDroid))
                    {
                        stackPD.Push(droidArray[k]);
                    }
                    else if (myDroid.GetType() == typeof(UtilityDroid))
                    {
                        stackUD.Push(droidArray[k]);
                    }
                    else if (myDroid.GetType() == typeof(AstroDroid))
                    {
                        stackAD.Push(droidArray[k]);
                    }
                }
            }
            Queue<Droid> droidQueue = new Queue<Droid>();
            while (stackAD.IsEmpty == false)
            {
                droidQueue.Enqueue(stackAD.Pop());
            }
            while (stackJD.IsEmpty == false)
            {
                droidQueue.Enqueue(stackJD.Pop());
            }
            while (stackUD.IsEmpty == false)
            {
                droidQueue.Enqueue(stackUD.Pop());
            }
            while (stackPD.IsEmpty == false)
            {
                droidQueue.Enqueue(stackPD.Pop());
            }
            int i = 0;
            while (droidQueue.Size > 0)
            {
                droidArray[i] = droidQueue.Dequeue();
                i++;
            }
        }
        //AddNewDroid initiates a loop that finds the first available slot in the DroidArray and asks user to specify type of droid they wish to create. Once
        //a new droid type is specified, many follow up questions are asked to see what features each new droid in inventory will have.
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
