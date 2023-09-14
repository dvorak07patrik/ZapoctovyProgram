using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    internal class TriangleInfo
    {
        public double Hypotenuse { get; set; }
        public double AngleAlpha { get; set; }
        public double AngleBeta { get; set; }
        public double ShorterLeg { get; set; }
        public double LongerLeg { get; set; }

        public TriangleInfo(double shorterLeg, double longerLeg)
        {
            ShorterLeg = shorterLeg;
            LongerLeg = longerLeg;
        }

        public void CalculateTriangle()
        {
            Hypotenuse = Math.Sqrt(ShorterLeg * ShorterLeg + LongerLeg * LongerLeg);

            // left upper
            AngleAlpha = Math.Atan2(LongerLeg, ShorterLeg) * (180.0 / Math.PI);

            // right button
            AngleBeta = Math.Atan2(ShorterLeg, LongerLeg) * (180.0 / Math.PI);
        }
    }
}
