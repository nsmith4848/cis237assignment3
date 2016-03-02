using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroids : UtilityDroid
    {
        private bool fireExtinguisherBool;

        private int numberOfShipsInt;

        private const decimal costPerShipDecimal = 67.50m;

        public AstromechDroids(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numberOfShips)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.fireExtinguisherBool = fireExtinguisher;
            this.numberOfShipsInt = numberOfShips;
        }

        public override void CalculateTotalCost()
        {
            if (fireExtinguisherBool == true)
            {
                base.baseCostDec += 25.00m;
            }

            base.baseCostDec += numberOfShipsInt * costPerShipDecimal;
        }
        public override string ToString()
        {
            string addOn = (numberOfShipsInt * costPerShipDecimal).ToString();
            if (fireExtinguisherBool == true) addOn += " includes a fire extinguisher";
            return base.ToString() + addOn;
        }

            
            
    }
}
