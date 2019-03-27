using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
    class UtilityDroid : Droid
    {
        //**************
        //Variables
        //**************
        private bool toolBox;
        private bool computerConnection;
        private bool arm;
        private decimal additionalFeatures=0;

        const decimal UTILITY_DROID = 1000;
        const decimal TOOLBOX_COST = 150;
        const decimal COMPUTER_CONNECTION_COST = 250;
        const decimal ARM_COST = 350;

        //**************
        //Properties
        //**************
        protected bool Toolbox
        {
            get { return toolBox; }
            set { toolBox = value; }

        }

        protected bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }

        }

        protected bool Arm
        {
            get { return arm; }
            set { arm = value; }

        }

        protected decimal AdditionalFeatures
        {
            get { return additionalFeatures; }
            set { additionalFeatures = value; }
        }

        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (AdjustedBaseCost + UTILITY_DROID + AdditionalFeatures);

        }

        public override string ToString()
        {
            return "***********************" + Environment.NewLine +"Utility Droid" + Environment.NewLine + Material + Environment.NewLine + Color + Environment.NewLine + "Toolbox: " + Toolbox.ToString() + Environment.NewLine + "Computer Connection: " + ComputerConnection.ToString()
                    + Environment.NewLine + "Arm: " + Arm.ToString() + Environment.NewLine + TotalCost.ToString("C") + Environment.NewLine + "***********************" + Environment.NewLine;
        }

        //**************
        //Constructor
        //**************
        public UtilityDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm) : base(Material, Color)
        {
            if (toolbox)
            {
                Toolbox = true;
                AdditionalFeatures += TOOLBOX_COST;
            }
            if (computerConnection)
            {
                ComputerConnection = true;
                AdditionalFeatures += COMPUTER_CONNECTION_COST;
            }
            if (arm)
            {
                Arm = true;
                AdditionalFeatures += ARM_COST;
            }
            CalculateTotalCost();
        }
    }
}
