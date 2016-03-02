using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorialDroid : UtilityDroid
    {
        private bool trashCompactorBool;
        private bool vacuumBool;

        public JanitorialDroid(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            :base(material, model, color, toolBox, computerConnection, arm)
        {
            this.trashCompactorBool = trashCompactor;
            this.vacuumBool = vacuum;
        }

        public override void CalculateTotalCost()
        {
            if (trashCompactorBool == true)
                base.baseCostDec += 40.00m;
            if (vacuumBool == true)
                base.baseCostDec += 40.00m;
        }

        public override string ToString()
        {
            string addOn = "";
            if (trashCompactorBool == true)
                addOn += " includes a trash compactor";
            if (vacuumBool == true)
                addOn += " includes a vacuum";
            return base.ToString() + addOn;
        }
    }
}
