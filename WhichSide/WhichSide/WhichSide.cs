using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichSide
{
    class StreetSideDeterminer
    {
    
        bool IsEven(int num)
        {
            return (num % 2 == 0);
        }

        public string DetermineWhichSide(DateTime date, bool verbose = true, bool houseEven = false)
        {
            // verbose: write step by step info to the console
            // houseEven: whether or not the house number is even
            // date: date and time to determine street side for

            int day;
            

            if (verbose) Console.WriteLine("The hour is {0}", date.Hour);

            if (date.Hour > 12)
            {
                if (verbose) Console.WriteLine("it is after noon.");

                // determine for tomorrow then
                day = date.AddDays(1).Day;
            }
            else
            {
                day = date.Day;
            }


            // day: the day of the month

            if (IsEven(day) && houseEven)
            {
                return "in front of house.";
            }
            else if (!IsEven(day) && !houseEven)
            {
                return "in front of house.";
            }
            else
            {
                return "across the street.";
            }

        }

        public string DetermineWhichSide(bool verbose = true, bool houseEven = false)
        {
            // Determine which side for current date and time
            // verbose: write step by step info to the console
            // houseEven: whether or not the house number is even

            return DetermineWhichSide(DateTime.Now, verbose, houseEven);
        }

    }
}
