using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            DroidCollection droidCollection = new DroidCollection();
            bool exitBool = false;
            while(exitBool == false)
            {
                int choice = userInterface.MainMenu();

                switch (choice)
                    {
                    case 1:
                        Droid inputDroid = userInterface.InputDroid();
                        droidCollection.AddDroid(inputDroid);
                        break;

                    case 2:
                        string output = droidCollection.ToString();
                        userInterface.PrintAllOutput(output);
                        break;
                    case 3:
                        exitBool = true;
                        break;
                    default:
                        userInterface.PrintError();
                        break;
                }
            }
        }        
    }    
}
