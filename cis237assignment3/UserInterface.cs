using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public int MainMenu()
        {
            Console.WriteLine("Please choose an option" + Environment.NewLine +
                "1.  Add an droid" + Environment.NewLine +
                "2.  Print a list of all droids" + Environment.NewLine +
                "3.  Exit the program");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public void PrintError()
        {
            Console.WriteLine("I'm Sorry, but that was not a valid input.  Please try again" + Environment.NewLine);
        }
    }
}
