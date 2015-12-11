using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertQuartsToLiters
{
    class QuartsToLiters
    {
        static void Main(string[] args)
        {
            string input;
            double quarts;

            WriteLine("How many quarts do you have?  ");
            input = ReadLine();
            quarts = Convert.ToDouble(input);

            WriteLine(DisplayQuartsToLiters(quarts));
        }
        private static double DisplayQuartsToLiters(double quartMethod)
        {
            double totalLiters;
            const double quartToLiters = 0.966353;

            totalLiters = quartMethod * quartToLiters;
            return totalLiters;
            
        }
    }
}
