using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid:IDroid
    {//backing fields
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        //Constructor
        public Droid(string Material,string Model,string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        //Properties
        public virtual decimal TotalCost 
        { 
            get
            {
                return totalCost;
            } 
            set
            {
                totalCost = value;
            } 
        }

        //Methods
        public abstract void CalculateTotalCost();

        public override string ToString()   //access ToString method allowing sub classes to  alter as needed.
        {
            return "Material: "+this.material + "Model: "+this.model + "Color: "+this.color;
        }
        protected virtual decimal CalculateBaseCost() //sets the base cost equal to the total cost.
        {
            this.baseCost = this.totalCost;
            return totalCost;
        }
    }
}