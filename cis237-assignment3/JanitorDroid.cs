using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class JanitorDroid : UtilityDroid
    {

        //**************
        //Variables
        //**************
        private bool trashCompactor;
        private bool vacuum;

        const decimal JANITOR_COST = 1000;
        const decimal TRASH_COST = 100;
        const decimal VACUUM_COST = 150;

        //**************
        //Properties
        //**************
        private bool TrashCompactor
        {
            get { return trashCompactor; }
            set { trashCompactor = value; }

        }

        private bool Vacuum
        {
            get { return vacuum; }
            set { vacuum = value; }

        }

        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (AdjustedBaseCost + JANITOR_COST + AdditionalFeatures);
        }

        public override string ToString()
        {
            return "Janitor Droid -" + Material + " , " + Color + " , " + "Toolbox: " + Toolbox.ToString() + " , " + "Computer Connection: " + ComputerConnection.ToString()
                    + " , " + "Arm: " + Arm.ToString() + " , " + "Trash Compactor: " + TrashCompactor.ToString() + " , " + "Vacuum: " + Vacuum.ToString() +
                    " , " + TotalCost.ToString("C") + Environment.NewLine;
        }
        //**************
        //Constructor
        //**************
        public JanitorDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : base(Material, Color, toolbox, computerConnection, arm)
        {
            if (trashCompactor)
            {
                TrashCompactor = true;
                AdditionalFeatures += TRASH_COST;
            }
            if (vacuum)
            {
                ComputerConnection = true;
                AdditionalFeatures += VACUUM_COST;
            }
            CalculateTotalCost();
        }
    }
}
