using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class TilingDemo
    {
        static void Main(string[] args)
        {

            WriteLine("What is the length?  ");
            int x = Convert.ToInt32(ReadLine());
            WriteLine("What is the height of the room?  ");
            int y = Convert.ToInt32(ReadLine());
            Room squareFeet = new Room(x,y);


            Write("The square feet of your room is {0} and",squareFeet.getFloorArea());
            Write(" you would need {0} many boxes.", squareFeet.getBoxes());





        }
    }
}
