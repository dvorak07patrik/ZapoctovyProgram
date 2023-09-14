using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZPProgram
{
    // class Side used for storing sides properties and counting sides parts
    //public instead of internatl becouse of error on Form2 constructor accesibility for Side type
    public class Side
    {
        public double Length { get; set; }
        public int Height { get; set; }
        public double NumberOfDoors { get; set; }
        public double Subtractor { get; set; }
        public int DoorsComboIndex { get; set; }

        // side constructor, assignes variables according to doorsComboIndex chosen by user
        public Side(int length, int height, int doorsComboIndex)
        {
            Length = length;
            Height = height;
            DoorsComboIndex = doorsComboIndex;
            if (doorsComboIndex == 0)
            {
                NumberOfDoors = 2;
                Subtractor = 16;
            }
            else if (doorsComboIndex == 1)
            {
                NumberOfDoors = 3;
                Subtractor = 16;
            }
            else if (doorsComboIndex == 2)
            {
                NumberOfDoors = 4;
                Subtractor = 16;
            }
            else if (doorsComboIndex == 3)
            {
                NumberOfDoors = 4;
                Subtractor = 24;
            }
            else if (doorsComboIndex == 4)
            {
                NumberOfDoors = 5;
                Subtractor = 24;
            }
            else if (doorsComboIndex == 5)
            {
                NumberOfDoors = 6;
                Subtractor = 24;
            }
            else
            {
                NumberOfDoors = 8;
                Subtractor = 24;
            }
        }

        // calls counting function for all parts
        public ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) CountParts()
        {
            return (CountHL(), CountV(), CountVM(), CountHSandBS(), CountHSandBS(), CountVA(), CountGlass());
        }

        public (int, int) CountGlass()
        {
            int width = CountHL().Item2 + 13;
            int height = CountV().Item2 - 94;
            return (width, height);
        }


        public (int, int) CountHL()
        {
            int HLCount;
            int HLLength;
            HLCount = Convert.ToInt32(NumberOfDoors * 2);
            // HLLength = Convert.ToInt32((Length - Subtractor) / NumberOfDoors);
            HLLength = Convert.ToInt32(Math.Floor(((Length + ((NumberOfDoors - 1) * 40) - Subtractor) / NumberOfDoors) - 76));
            return (HLCount, HLLength);
        }

        public (int, int) CountV()
        {
            int VCount;
            if (DoorsComboIndex < 3)
            {
                VCount = 2;
            }
            else
            {
                VCount = 4;
            }
            int VLength = Height - 33;
            return (VCount, VLength);

        }

        public (int, int) CountVM()
        {
            int VMCount = (Convert.ToInt32(NumberOfDoors) * 2) - CountV().Item1;
            int VMLength = Height - 33;
            return (VMCount, VMLength);
        }

        public (int, int) CountHSandBS()
        {
            int HSCount = 1;
            int HSLength = Convert.ToInt32(Length);
            return (HSCount, HSLength);
        }

        public (int, int) CountVA()
        {
            int VACount;
            if (DoorsComboIndex < 3 || DoorsComboIndex == -1)
            {
                VACount = 2;
            }
            else
            {
                VACount = 4;
            }
            int VALength = Height - 4;
            return(VACount, VALength);

        }

    }
}
