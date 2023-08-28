using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPProgram
{
    //public instead of internatl becouse of error on Form2 constructor accesibility for Side type
    public class Side
    {
        private double Length { get; set; }
        private int Height { get; set; }
        private double NumberOfDoors { get; set; }
        private double Subtractor { get; set; }
        private int DoorsComboIndex { get; set; }

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

        public ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) CountParts()
        {
            return (CountHL(), CountV(), CountVM(), CountHSandBS(), CountHSandBS(), CountVA());
            
        }

        public (int,int) CountHL()
        {
            int HLCount;
            int HLLength;
            HLCount = Convert.ToInt32(NumberOfDoors * 2);
            HLLength = Convert.ToInt32((Length - Subtractor) / NumberOfDoors);
            HLLength = Convert.ToInt32(((Length + ((NumberOfDoors - 1) * 40) - 16) / NumberOfDoors) - 76);
            return (HLCount, HLLength);
        }

        public (int,int) CountV()
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

        public (int,int) CountVM()
        {
            int VMCount = (Convert.ToInt32(NumberOfDoors) * 2) - CountV().Item1;
            int VMLength = Height - 33;
            return(VMCount, VMLength);
        }

        public (int,int) CountHSandBS()
        {
            int HSCount = 1;
            int HSLength = Convert.ToInt32(Length);
            return(HSCount, HSLength);
        }

        public (int,int) CountVA()
        {
            int VACount;
            if (DoorsComboIndex < 3)
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
