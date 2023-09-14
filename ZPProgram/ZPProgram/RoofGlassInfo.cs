using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    internal class RoofGlassInfo
    {
        private double RafterWidth = 100;
        //space for screw
        private double RafterSpace = 20;
        private double TopOverlap = 100;
        private double BottomOverlap = 30;
        private double SideOverlap = 20;

        public int Count;
        public double Length;
        public double MidGlassWidth;
        public double SideGlassWidth;
        public double RafterSpacing;

        public RoofGlassInfo(int count, double length)
        {
            Count = count;
            Length = length;
        }


        public void CalculateGlass(double rafterSpacing)
        {
            SideGlassWidth = rafterSpacing + RafterWidth + ((RafterWidth - RafterSpace) / 2) + SideOverlap;
            MidGlassWidth = rafterSpacing + (RafterWidth - RafterSpace);
            Length += TopOverlap + BottomOverlap;
        }
    }
}
