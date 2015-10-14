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
            Protocol protocol = new Protocol("Titanium","New","Black",1200);
            protocol.ToString();
        }
    }
}
