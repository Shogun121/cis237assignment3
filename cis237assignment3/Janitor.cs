using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor:Utility
    {
        //backing fields
        protected bool trashCompactor;
        protected bool vaccum;

        protected const decimal trashCompactor_Cost = 100m;
        protected const decimal vaccum_Cost = 80;

        //Constructor
        public Janitor(string Material, string Model, string Color, bool Toolbox, bool ComputerConnection, bool Arm,bool TrashCompactor ,bool Vaccum)
            : base(Material,Model,Color,Toolbox,ComputerConnection,Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vaccum = Vaccum;
        }

        //Properties

        //Methods
        public override string ToString()
        {
            return base.ToString() + " Trash Compactor: " + trashCompactor + " Vaccum: " + vaccum;
        }
        public override void CalculateTotalCost()   //Calculates the cost of a janitor droid based on the features included.
        {
            if(trashCompactor)
            {
                totalCost += trashCompactor_Cost;
            }
            if(vaccum)
            {
                totalCost += vaccum_Cost;
            }
            totalCost += baseCost;
        }
    }
}
