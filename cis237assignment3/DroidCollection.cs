using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        Droid[] droids = new Droid[100];

        public void AddDroid(Droid addDroid)
        {
            int counter = 0;
            for (counter = 0; counter < droids.Length; counter++)
            {
                if (droids[counter] == null)
                {
                    droids[counter] = addDroid;
                    return;
                }
            }
        }

        public string getList()
        {
            string allOutput = "";
            foreach(Droid in droids)
            {
                if(Droid != null)
                {
                    allOutput += Droid
                }
            }
        }
    }
}
