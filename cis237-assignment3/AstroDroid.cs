using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
{
    class AstroDroid : UtilityDroid
    {
        //**************
        //Variables
        //**************
        private bool fireExtinquisher;
        private int numberShips;

        const decimal ASTRO_COST = 2000;
        const decimal FIRE_COST = 250;
        const decimal COST_PER_SHIP = 200;

        //**************
        //Properties
        //**************
        private bool FireExtinquisher
        {
            get { return fireExtinquisher; }
            set { fireExtinquisher = value; }

        }

        private int NumberShips
        {
            get { return numberShips; }
            set { numberShips = value; }

        }

        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (AdjustedBaseCost + ASTRO_COST + AdditionalFeatures);
        }

        public override string ToString()
        {
            return "***********************" + Environment.NewLine + "Astro Droid " + Environment.NewLine + Material + Environment.NewLine + Color + Environment.NewLine + "Toolbox: " + Toolbox.ToString() + Environment.NewLine + "Computer Connection: " + ComputerConnection.ToString()
                    + Environment.NewLine + "Arm: " + Arm.ToString() + Environment.NewLine + "Fire Extinquisher: " + FireExtinquisher.ToString() + Environment.NewLine + "Number of Ships to Service: " + NumberShips.ToString() +
                    Environment.NewLine + TotalCost.ToString("C") + Environment.NewLine +"***********************" + Environment.NewLine;
        }


        //**************
        //Constructor
        //**************
        public AstroDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm, bool fireExtinquisher, int numberShips) : base(Material, Color, toolbox, computerConnection, arm)
        {
            if (fireExtinquisher)
            {
                FireExtinquisher = true;
                AdditionalFeatures += FIRE_COST;
            }
            if (numberShips != 0)
            {
                NumberShips = numberShips;
                AdditionalFeatures += (numberShips * COST_PER_SHIP);
            }
            CalculateTotalCost();
        }
    }
}
