using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol:Droid
    {
        //Backing fields
        private int numberLanguage;
        private const decimal cost_per_language=50m;

        //Constructor
        public Protocol(string Material,string Model,string Color,int BaseCost):base(Material,Model,Color)
        {

        }

        //Propeties

        //Methods
        public override string ToString()
        {
            return base.ToString()+"Base Cost: "+this.baseCost+Environment.NewLine;
        }
        public override void CalculateTotalCost()
        {
            totalCost = baseCost * (cost_per_language * numberLanguage);
        }
    }
}
