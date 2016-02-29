using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        protected bool toolBoxBool;
        protected bool computerConnectionBool;
        protected bool armBool;

        public UtilityDroid(string material, string model, string color, bool toolBox, bool computerConnection, bool arm) : base(material,model,color)
        {
            this.toolBoxBool = toolBox;
            this.computerConnectionBool = computerConnection;
            this.armBool = arm;
        }

        public override void CalculateTotalCost()
        {
             if(toolBoxBool == true)
            {
                baseCostDec += 45.00m;
            }

             if(computerConnectionBool == true)
            {
                baseCostDec += 20.00m;
            }

             if(armBool == true)
            {
                baseCostDec += 10.00m;
            }
        }

        public override string ToString()
        {
            string addOnString = "";
            if(toolBoxBool == true)
            {
                addOnString = " Includes a ToolBox";
            }

            if(computerConnectionBool ==true)
            {
                addOnString += " includes a Computer Connection";
            } 

            if(armBool == true)
            {
                addOnString += " includes an arm";
            }

            return base.ToString() + addOnString;
        }
    }
}
