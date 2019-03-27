using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
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

        //Not quite the standard materials used to construct droids. Awaiting a repsonse from the Jawas on what these should be renamed to.
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
            return "Droid -" + Material + Environment.NewLine + Color + Environment.NewLine + TotalCost.ToString("C") + Environment.NewLine;
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
