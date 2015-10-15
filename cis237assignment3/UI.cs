using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UI
    {
        //Backing fields
        private bool exit=false;
        private int userChoice;
        private const int menuOptions=2;
        //Constructor

        //Properties

        //Methods
        public void MenuLoop()
        {
            while(exit==false)
            {
                Console.WriteLine("1)......Add a Droid.");
                Console.WriteLine("2)......Print Driod list.");
            }
        }
        public void Error()
        {
            Console.WriteLine("Input is invalid");  //display if input is invalid.
        }
        public void PromptUser()
        {
            Console.WriteLine();
            Console.Write("Make a selection: ");
        }
        public string GetResponse()
        {
            return Console.ReadLine();
        }
        //Verify input integrity
        public bool VerifyInput(string input)
        {
            bool VerifiedInput=false;
            try
            {
                userChoice=Int32.Parse(input);
                if(userChoice>0 && userChoice<menuOptions)
                {
                    VerifiedInput = true;
                }
            }
            catch(Exception ex)
            {
                VerifiedInput = false;
            }
            return VerifiedInput;
        }
    }
}
