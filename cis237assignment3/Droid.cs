using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        //Backing Fields
        protected string materialString;
        protected string modelString;
        protected string colorString;

        protected decimal baseCostDec;
        protected decimal totalCostDec;

        public string MaterialString
        {
            get
              { return this.materialString; }
        }

        public string ModelString
        {
            get
            { return this.modelString; }
        }

        public string ColorString
        {
            get
            {
                return this.colorString;
            }
        }

        public decimal TotalCost
        {
            get
            {
                CalculateTotalCost();
                return this.baseCostDec;
            }
            set
            {
                totalCostDec = value;
            }
        }
        //3 parameter constructor set as the basis of all droid sub-classes

        public Droid(string material, string model, string color)
        {
            materialString = material;
            modelString = model;
            colorString = color;
            switch (materialString)
            {
                case "Aluminum":
                    this.baseCostDec = 10.00m;
                    break;
                case "Steel":
                    this.baseCostDec = 20.00m;
                    break;
                case "Titanium":
                    this.baseCostDec = 50.00m;
                    break;
            }

        }

        public override string ToString()
        {
            return this.materialString + " " + this.modelString + " " + this.colorString + " " + this.totalCostDec.ToString("C");
        }

        public abstract void CalculateTotalCost();
    }
}
