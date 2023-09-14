using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    public class WinterGarden
    {
        public double Length;
        public double Width;
        public double BackHeight;
        public double FrontHeight;
        public TriangleInfo Triangle;
        public RafterInfo Rafter;
        public RoofGlassInfo RoofGlass;


        public WinterGarden(double length, double width, double backHeight, double frontHeight) 
        {
            Length = length;
            Width = width;
            BackHeight = backHeight;
            FrontHeight = frontHeight + 100;
        }

        public void CalculateRoof()
        {
            // calculation of glass triangle
            // minus upper rafter
            double shortLeg = BackHeight - 100 - FrontHeight;
            double longLeg = Length - 200;
            Triangle = new TriangleInfo(shortLeg, longLeg);
            Triangle.CalculateTriangle();

            Rafter = new RafterInfo(Triangle.Hypotenuse, Triangle.AngleBeta);
            Rafter.CalculateRafter(Width);

            RoofGlass = new RoofGlassInfo(Rafter.Count, Rafter.Length);
            RoofGlass.CalculateGlass(Rafter.RafterSpacing);


            // return (triangle.Hypotenuse, triangle.)
        }

        
    }
}
