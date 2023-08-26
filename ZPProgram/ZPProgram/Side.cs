using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    internal class Side
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int NumberOfDoors { get; set; }

        public Side(int length, int height, int numberOfDoors) 
        { 
            Length = length;
            Height = height;
            NumberOfDoors = numberOfDoors;
        }
    }
}
