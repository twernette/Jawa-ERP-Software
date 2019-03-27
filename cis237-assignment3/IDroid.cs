using System;

namespace Jawa_ERP_Software
{
    interface IDroid
    {
        // Method to calculate the total cost of a droid
        void CalculateTotalCost();

        // Property to get the total cost of a droid
        decimal TotalCost { get; set; }
    }
}
