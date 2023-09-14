using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    internal class RafterInfo
    {
        public double Length { get; set; }
        public double Angle { get; set; }
        public int Count { get; set; }
        public double RafterSpacing { get; set; }
        public RafterInfo(double length, double angle) 
        {
            Length = length;
            Angle = angle;
        }

        public void CalculateRafter(double gardenWidth)
        {
            Count = Convert.ToInt32((gardenWidth / 1000) + 1);
            if (Count < 2) { Count = 2; }
            RafterSpacing = (gardenWidth - (100 * Count)) / (Count - 1);
        }
    }
}
