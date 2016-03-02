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

        public Droid InputDroid()
        {
            string material;
            string model;
            string color;

            Console.WriteLine("Please Select a material the droid is made from" + Environment.NewLine +
                "1.  Aluminum" + Environment.NewLine +
                " 2.  Steel" + Environment.NewLine + 
                "3.  Titanium" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    material = "Aluminum";
                    break;
                case "2":
                    material = "Steel";
                    break;
                case "3":
                    material = "Titanium";
                    break;
                default:
                    Console.WriteLine("You did not select a valid option.  Please try again");
                    return null;
            }

            Console.WriteLine("Please enter the color of the droid" + Environment.NewLine);

            color = Console.ReadLine();

            Console.WriteLine("Please select the kind of droid you are logging in" + Environment.NewLine +
                "1.  Protocol Droid" + Environment.NewLine + 
                "2.  Utility Droid" + Environment.NewLine + 
                "3.  Janitorial Droid" + Environment.NewLine +
                "4.  Astromech Droid" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    model = "Protocol Droid";
                    ProtocolDroid protocolDroid = inputProtocolDroid(material, color, model);
                    return protocolDroid;                   
                case "2":
                    model = "Utility Droid";
                    UtilityDroid utilityDroid = inputUtilityDroid(material, color, model);
                    return utilityDroid;
                case "3":
                    model = "Janitorial Droid";
                    JanitorialDroid janitorialDroid = inputJanitorialDroid(material, color, model);
                    return janitorialDroid;
                case "4":
                    model = "Astromech Droid";
                    AstromechDroids astromechDroid = inputAstromechDroid(material, color, model);
                    return astromechDroid;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
        }

        private ProtocolDroid inputProtocolDroid(string material, string color, string model)
        {
            int languagesknown;
            Console.WriteLine("How many languages does the droid know?" + Environment.NewLine);
            try
            {
                languagesknown = int.Parse(Console.ReadLine());
                return new ProtocolDroid(material, color, model, languagesknown);                    
            }
            catch
            {
                Console.WriteLine("I'm sorry, but you did not input a number");
                return null;
            }
        }

        private UtilityDroid inputUtilityDroid (string material, string color, string model)
        {
            bool toolBox;
            bool computerConnection;
            bool arm;            

            Console.WriteLine("Does the droid have a tool box?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    toolBox = true;
                    break;
                case "2":
                    toolBox = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid value.  Please try again.");
                    return null;
            }
            Console.WriteLine("Does the droid have a computer connection" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    computerConnection = true;
                    break;
                case "2":
                    computerConnection = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }

            Console.WriteLine("Does the droid have an arm?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    arm = true;
                    break;
                case "2":
                    arm = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
            return new UtilityDroid(material, model, color, toolBox, computerConnection, arm);
        }
        private JanitorialDroid inputJanitorialDroid(string material, string model, string color)
        {
            bool toolBox;
            bool computerConnection;
            bool arm;
            bool trashCompactor;
            bool vacuum;

            Console.WriteLine("Does the droid have a tool box?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    toolBox = true;
                    break;
                case "2":
                    toolBox = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid value.  Please try again.");
                    return null;
            }
            Console.WriteLine("Does the droid have a computer connection" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    computerConnection = true;
                    break;
                case "2":
                    computerConnection = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }

            Console.WriteLine("Does the droid have an arm?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    arm = true;
                    break;
                case "2":
                    arm = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
            Console.WriteLine("Does the droid have a trash compactor?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    trashCompactor = true;
                    break;
                case "2":
                    trashCompactor = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
            Console.WriteLine("Does the droid have a vacuum?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    vacuum = true;
                    break;
                case "2":
                    vacuum = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
            return new JanitorialDroid(material, model, color, toolBox, computerConnection, arm, trashCompactor, vacuum);
        }

        private AstromechDroids inputAstromechDroid(string material, string model, string color)
        {
            bool toolBox;
            bool computerConnection;
            bool arm;
            bool fireExinguisher;
            int numberOfShips;

            Console.WriteLine("Does the droid have a tool box?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    toolBox = true;
                    break;
                case "2":
                    toolBox = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid value.  Please try again.");
                    return null;
            }
            Console.WriteLine("Does the droid have a computer connection" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    computerConnection = true;
                    break;
                case "2":
                    computerConnection = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }

            Console.WriteLine("Does the droid have an arm?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch (Console.ReadLine())
            {
                case "1":
                    arm = true;
                    break;
                case "2":
                    arm = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }

            Console.WriteLine("Does the droid have a fire extinguisher?" + Environment.NewLine +
                "1.  Yes" + Environment.NewLine +
                "2.  No" + Environment.NewLine);
            switch(Console.ReadLine())
            {
                case "1":
                    fireExinguisher = true;
                    break;
                case "2":
                    fireExinguisher = false;
                    break;
                default:
                    Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                    return null;
            }
            try
            {
                Console.WriteLine("Please enter the number of ships the droids is working on in numeric form" + Environment.NewLine);
                numberOfShips = int.Parse(Console.ReadLine());
                return new AstromechDroids(material, model, color, toolBox, computerConnection, arm, fireExinguisher, numberOfShips);
            }
            catch
            {
                Console.WriteLine("I'm sorry, you did not enter a valid entry.  Please try again");
                return null;
            }
        }
    }
}
