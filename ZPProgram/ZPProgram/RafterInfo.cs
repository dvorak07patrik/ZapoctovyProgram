using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    public class RafterInfo
    {
        public double Length { get; set; }
        public double Angle { get; set; }
        public int Count { get; set; }
        public double RafterSpacing { get; set; }
        static int rafterWidth = 100;
        static int divisorForGlassCount = 1000;

        public RafterInfo(double length, double angle) 
        {
            Length = length;
            Angle = angle;
        }

        public void CalculateRafter(double gardenWidth)
        {
            // formula for glass width to be around 1 meter
            Count = Convert.ToInt32((gardenWidth / divisorForGlassCount) + 1);
            if (Count < 2) { Count = 2; }
            RafterSpacing = (gardenWidth - (rafterWidth * Count)) / (Count - 1);
        }
    }
}
