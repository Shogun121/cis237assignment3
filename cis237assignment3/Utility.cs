using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility:Droid
    {
        //backing fields
        protected bool toolbox;
        protected bool computerConnection;
        protected bool arm;

        protected const decimal toolbox_Cost = 115m;
        protected const decimal computerConnection_Cost = 300;
        protected const decimal arm_Cost = 250m;

        //protected const decimal allOptions=115+300+250;
        //protected const decimal noOptions = 0m;

        //Constructor
        public Utility(string Material, string Model, string Color,bool Toolbox, bool ComputerConnection,bool Arm):base(Material,Model,Color)
        {
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }

        //Properties

        //Methods
        public override string ToString()
        {
            return base.ToString() + "Toolbox: " + this.toolbox + " Computer Connection: " + this.computerConnection + " Arm: " + this.arm;
        }
        public override void CalculateTotalCost()   //Calculates the cost of a utility droid based upon base cost and each feature added.
        {
            if(toolbox)
            {
                totalCost += toolbox_Cost;
            }
            if(computerConnection)
            {
                totalCost += computerConnection_Cost;
            }
            if(arm)
            {
                totalCost += arm_Cost;
            }
            totalCost += baseCost;
            
        }
    }
}
