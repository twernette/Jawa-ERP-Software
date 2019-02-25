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
        public decimal TotalCost { get; set; }

        const decimal wood = 1;
        const decimal brick = 2;
        const decimal metal = 3;


        //**************
        //Methods
        //**************

        public virtual void CalculateBaseCost()
        {
            

        }
        public abstract void CalculateTotalCost();

        //**************
        //Constructor
        //**************
        public Droid(string material, string color)
        {

            this.material = material;
            this.color = color;
        }
    }
}
