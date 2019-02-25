using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
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
        public bool FireExtinquisher
        {
            get { return fireExtinquisher; }
            set { fireExtinquisher = value; }

        }

        public int NumberShips
        {
            get { return numberShips; }
            set { numberShips = value; }

        }

        //**************
        //Methods
        //**************
        public override void CalculateTotalCost()
        {
            TotalCost = (adjustedBaseCost + ASTRO_COST + additionalFeatures);
        }




        //**************
        //Constructor
        //**************
        public AstroDroid(string Material, string Color, bool toolbox, bool computerConnection, bool arm, bool fireExtinquisher, int numberShips) : base(Material, Color, toolbox, computerConnection, arm)
        {
            if (fireExtinquisher)
            {
                FireExtinquisher = true;
                additionalFeatures += FIRE_COST;
            }
            if (numberShips != 0)
            {
                NumberShips = numberShips;
                additionalFeatures += (numberShips * COST_PER_SHIP);
            }
        }
    }
}
