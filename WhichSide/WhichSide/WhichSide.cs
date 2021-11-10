using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichSide
{
    public class WhichSide
    {
    
        static bool IsEven(int num)
        {
            return (num % 2 == 0);
        }

        public static string CheckWhichSide(DateTime date, bool houseEven, bool verbose = true)
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
    }
}
