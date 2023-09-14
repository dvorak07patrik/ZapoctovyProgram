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

        

        static int GlassWidthOverlap = 13;
        static int GlassHeightOverlap = -93;
        static int HLLengthFormulaMultiplier = 40;
        static int HLFinalSubstract = -76;
        static int VSubstraction = -33;
        static int VMSubstaction = VSubstraction;
        static int VASubstraction = -4;
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
        public ((int Count, int Length) HL, (int Count, int Length) V, (int Count, int Length) VM, (int Count, int Length) BS, (int Count, int Length) HS, (int Count, int Length) VA, (int Width, int Height) Glass) CountParts()
        {
            ((int Count, int Length) HL, (int Count, int Length) V, (int Count, int Length) VM, (int Count, int Length) BS, (int Count, int Length) HS, (int Count, int Length) VA, (int Width, int Height) Glass) parts;
            parts.HL = CountHL();
            parts.V = CountV();
            parts.VM = CountVM();
            parts.BS = CountHSandBS();
            parts.HS = CountHSandBS();
            parts.VA = CountVA();
            parts.Glass = CountGlass();
            return (parts);
        }

        // counts glass with the help of HL and V lengths
        public (int, int) CountGlass()
        {
            (int width, int height) glass;
            glass.width = CountHL().Item2 + GlassWidthOverlap;
            glass.height = CountV().Item2 + GlassHeightOverlap;
            return glass;
        }


        // counts HL part with formula
        // HLLengthFormulaMultiplier is for overlap of V parts
        // HL is on the top and on the buttom of the door and rides inside of BS and HS for doors to be movable
        public (int, int) CountHL()
        {
            (int Count, int Length)HL;

            HL.Count = Convert.ToInt32(NumberOfDoors * 2);
            HL.Length = Convert.ToInt32(Math.Floor(((Length + ((NumberOfDoors - 1) * HLLengthFormulaMultiplier) - Subtractor) / NumberOfDoors) + HLFinalSubstract));
            return HL;
        }

        // counts V part with (height minus BS and HS)
        // V part goes inside VA part in the system
        public (int, int) CountV()
        {
            (int Count, int Length) V;
            if (DoorsComboIndex < 3)
            {
                V.Count = 2;
            }
            else
            {
                V.Count = 4;
            }
            V.Length = Height + VSubstraction;
            return V;

        }

        // counts VM part with (height minus BS and HS
        // VM part in on one side of door or on each side and catches VM on other door to move more door at once
        public (int, int) CountVM()
        {
            (int Count, int Length) VM;
            VM.Count = (Convert.ToInt32(NumberOfDoors) * 2) - CountV().Item1;
            VM.Length = Height + VMSubstaction;
            return VM;
        }

        // rail parts where doors move
        // same length as side length
        public (int, int) CountHSandBS()
        {
            (int Count, int Length) HS;
            HS.Count = 1;
            HS.Length = Convert.ToInt32(Length);
            return HS;
        }

        // bar in which goes V part of doors
        // count as higth minus small few milimeters
        public (int, int) CountVA()
        {
            (int Count, int Length) VA;
            if (DoorsComboIndex < 3 || DoorsComboIndex == -1)
            {
                VA.Count = 2;
            }
            else
            {
                VA.Count = 4;
            }
            VA.Length = Height + VASubstraction;
            return VA;

        }

    }
}
