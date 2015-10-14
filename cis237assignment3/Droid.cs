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
        Droid(string material,string model,string color)
        {

        }

        //Properties
        abstract decimal TotalCost 
        { 
            get
            {
                return TotalCost;
            } 
            set
            {
                TotalCost = value;
            } 
        }

        //Methods
        abstract void CalculateTotalCost();

        protected virtual override string ToString()   //access ToString method allowing sub classes to  alter as needed.
        {
            return base.ToString();
        }
        protected virtual decimal CalculateBaseCost() //sets the base cost equal to the total cost.
        {
            this.baseCost = this.totalCost;
            return totalCost;
        }
    }
}