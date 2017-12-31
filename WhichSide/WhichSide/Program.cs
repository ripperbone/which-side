using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichSide
{
    class Program
    {




        static void Main(string[] args)
        {
            StreetSideDeterminer whichSide = new StreetSideDeterminer();
            Console.WriteLine(whichSide.DetermineWhichSide());

            
        }
    }
}
