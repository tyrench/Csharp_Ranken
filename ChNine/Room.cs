using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Room 
    {
        int width { get; }
        int length { get; }
        int floorArea;
        int boxes;


        public Room(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getFloorArea()
        {
            floorArea = length * width;
            return floorArea;
        }

        private int cBoxes(int squareFeet)
        {
            int quad = squareFeet / 12;
            int remainder = squareFeet % 12;
            int extra;
            if (remainder == 0)
            {
                extra = 0;
            }
            else
            {
                extra = 1;
            }
            return quad + extra + 1;
        }
        public int getBoxes()
        {
            return cBoxes(floorArea);
        }

    }
}
