using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UtilityDroid : Droid
    {
        //**************
        //Variables
        //**************
        private bool toolBox;
        private bool computerConnection;
        private bool arm;
        protected decimal additionalFeatures=0;

        const decimal UTILITY_DROID = 1000;
        const decimal TOOLBOX_COST = 150;
        const decimal COMPUTER_CONNECTION_COST = 250;
        const decimal ARM_COST = 350;

        //**************
        //Properties
        //**************
        public bool Toolbox
        {
            get { return toolBox; }
            set { toolBox = value; }

        }

        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }

        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }

        }


        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (adjustedBaseCost + UTILITY_DROID + additionalFeatures);

        }

        public override string ToString()
        {
            return base.ToString() ;
        }

        //**************
        //Constructor
        //**************
        public UtilityDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm) : base(Material, Color)
        {
            if (toolbox)
            {
                Toolbox = true;
                additionalFeatures += TOOLBOX_COST;
            }
            if (computerConnection)
            {
                ComputerConnection = true;
                additionalFeatures += COMPUTER_CONNECTION_COST;
            }
            if (arm)
            {
                Arm = true;
                additionalFeatures += ARM_COST;
            }

        }
    }
}
