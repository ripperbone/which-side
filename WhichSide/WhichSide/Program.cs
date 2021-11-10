using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichSide
{
    class Program
    {
        static int Main(string[] args)
        {
            bool verbose = false;
            bool houseEven = false;
            foreach (string opt in args)
            {
                switch (opt)
                {
                    case "-v":
                        verbose = true;
                        break;
                    case "-e":
                        houseEven = true;
                        break;
                    case "-h":
                        Console.WriteLine($"Usage: {System.AppDomain.CurrentDomain.FriendlyName} [-e] [-h] [-v]");
                        return 1;
                }
            }


            Console.WriteLine(WhichSide.CheckWhichSide(DateTime.Now, houseEven: houseEven, verbose: verbose));
            return 0;
        }
    }
}
