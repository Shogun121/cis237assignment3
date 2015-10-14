using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech:Utility
    {
        //backing field
        protected bool fireExtinguisher;
        protected int numberShips;

        protected const decimal fireExintinguisher_Cost = 100m;
        protected const decimal cost_per_Ship = 40m;

        //Constructor
        public Astromech(string Material, string Model, string Color, bool Toolbox, bool ComputerConnection, bool Arm,bool FireExtinguisher,int NumberShips)
            : base(Material,Model,Color,Toolbox,ComputerConnection,Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }

        //Properties

        //Methods
        public override string ToString()
        {
            return base.ToString() + " FireExtinguisher: " + fireExtinguisher + " Number of Ships: " + numberShips;
        }
        public override void CalculateTotalCost()
        {
            if(fireExtinguisher)
            {
                totalCost += fireExintinguisher_Cost;
            }
            if(numberShips<0)
            {
                totalCost += (cost_per_Ship * numberShips);
            }
        }
    }
}
