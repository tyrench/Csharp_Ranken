using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureList
{
    class TempList
    {
        static void Main(string[] args)
        {
            int[] scores = new int[7];
            int x;
            string inputString;


            for (x = 0; x < scores.Length; ++x)
            {
                Write("enter the high of day {0}  ", x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            WriteLine("Scores in original order:   ");
            for (x = 0; x < scores.Length; ++x)
            { WriteLine("{0,6}", scores[x]); }

            
            

        }
    }
}
