using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public abstract class Droid : IDroid
    {

        //**************
        //Variables
        //**************
        private string material;
        private string color;
        private decimal baseCost = 1000;
        private decimal totalCost;
        private decimal adjustedBaseCost;
        private decimal materialCost;

        //Yeah these probably aren't the type of materials that you'd see droids made out of, but work with me.
        const decimal WOOD = 1;
        const decimal BRICK = 2;
        const decimal METAL = 3;

        //**************
        //Properties
        //**************
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        protected string Material
        {
            get { return material; }
            set { material = value; }

        }

        protected string Color
        {
            get { return color; }
            set { color = value; }

        }

        protected decimal AdjustedBaseCost
        {
            get { return adjustedBaseCost; }
            set { adjustedBaseCost = value; }
        }


        //**************
        //Methods
        //**************
        public override string  ToString()
        {
            return "Droid -" + Material + " , " + Color + " , " + TotalCost.ToString("C") + Environment.NewLine;
        }

        protected virtual void CalculateBaseCost()
        {
            adjustedBaseCost = (baseCost * materialCost);
        }

        public abstract void CalculateTotalCost();

        //**************
        //Constructor
        //**************
        public Droid(string material, string color)
        {

            this.material = material;
            this.color = color;
            if (material == "wood")
            { materialCost = WOOD; }
            if (material == "brick")
            { materialCost = BRICK; }
            if (material == "metal")
            { materialCost = METAL; }
            CalculateBaseCost();
        }
    }
}
