using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class ProtocolDroid : Droid
    {

        //**************
        //Variables
        //**************
        private decimal numberOfLanguages;
        const decimal COST_PER_LANGUAGE = 200;
        const decimal PROTOCOL_PRICE = 1500;

        //**************
        //Properties
        //**************

        public decimal NumberOfLanguages
        {
            get { return numberOfLanguages; }
            set { numberOfLanguages = value; }

        }
        //**************
        //Methods
        //**************

        public override string ToString()
        {
            return "Protocol Droid -" + Material + " , " + Color + " , " + "Number of languages: " + NumberOfLanguages.ToString() + " , " + TotalCost.ToString("C") + Environment.NewLine;
        }

        public override void CalculateTotalCost()
        {
            TotalCost = (AdjustedBaseCost + PROTOCOL_PRICE + (numberOfLanguages * COST_PER_LANGUAGE));
        }

        //**************
        //Constructor
        //**************

        public ProtocolDroid(string material, string color, int languages) : base(material, color)
        {
            NumberOfLanguages = languages;
            CalculateTotalCost();
        }
    }
}
