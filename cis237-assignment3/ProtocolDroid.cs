using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jawa_ERP_Software
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

        protected decimal NumberOfLanguages
        {
            get { return numberOfLanguages; }
            set { numberOfLanguages = value; }

        }
        //**************
        //Methods
        //**************

        public override string ToString()
        {
            return "***********************" + Environment.NewLine + "Protocol Droid" + Environment.NewLine + Material + Environment.NewLine + Color + Environment.NewLine + "Number of languages: " 
                + NumberOfLanguages.ToString() + Environment.NewLine + TotalCost.ToString("C") + Environment.NewLine + "***********************" + Environment.NewLine;
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
