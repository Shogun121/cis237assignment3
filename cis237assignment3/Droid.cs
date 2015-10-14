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
        abstract decimal TotalCost 
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
        protected virtual void CalculateTotalCost();

        protected override string ToString()   //access ToString method allowing sub classes to  alter as needed.
        {
            return "Material: "+this.material+Environment.NewLine + "Model: "+this.model+Environment.NewLine + "Color: "+this.color+Environment.NewLine;
        }
        protected virtual decimal CalculateBaseCost() //sets the base cost equal to the total cost.
        {
            this.baseCost = this.totalCost;
            return totalCost;
        }
    }
}