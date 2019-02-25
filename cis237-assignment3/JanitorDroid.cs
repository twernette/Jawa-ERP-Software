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
        public bool TrashCompactor
        {
            get { return trashCompactor; }
            set { trashCompactor = value; }

        }

        public bool Vacuum
        {
            get { return vacuum; }
            set { vacuum = value; }

        }

        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (adjustedBaseCost + JANITOR_COST + additionalFeatures);
        }


        //**************
        //Constructor
        //**************
        public JanitorDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : base(Material, Color, toolbox, computerConnection, arm)
        {
            if (trashCompactor)
            {
                TrashCompactor = true;
                additionalFeatures += TRASH_COST;
            }
            if (vacuum)
            {
                ComputerConnection = true;
                additionalFeatures += VACUUM_COST;
            }
        }
    }
}
