using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        private int numberLanguagesInt;

        public ProtocolDroid(string material, string model, string color, int numberLanguages) : base(material, model, color)
            {
                this.numberLanguagesInt = numberLanguages;
            }

        public override void CalculateTotalCost()
        {
           baseCostDec = numberLanguagesInt * base.baseCostDec;
        }

        public override string ToString()
        {
            return base.ToString() + " Number of Languages known" + numberLanguagesInt.ToString();
        }
    }
}
