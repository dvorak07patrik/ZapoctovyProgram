using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPProgram
{
    public partial class Form2 : Form
    {

        private Side LeftSide;
        private Side RightSide;
        private Side MidSide;
        private int VWidth = 10;
        private int HLHeight = 15;

        // constructs Form2 variables
        public Form2(Side leftSide, Side rightSide, Side midSide)
        {
            InitializeComponent();
            LeftSide = leftSide;
            RightSide = rightSide;
            MidSide = midSide;
        }

        // paints 2D visualisation of sides
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            int start = 30;
            Font font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold, GraphicsUnit.Pixel);
            if (LeftSide != null)
            {
                e.Graphics.DrawString("Levá strana - " + LeftSide.length.ToString()+ "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) leftSidePartsValues = LeftSide.CountParts();
                PrintSide(LeftSide, leftSidePartsValues, start, e);
                start += 500;
            }
            if (MidSide != null)
            {
                e.Graphics.DrawString("Prostřední strana - " + MidSide.length.ToString() + "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) midSidePartsValues = MidSide.CountParts();
                PrintSide(MidSide, midSidePartsValues, start, e);
                start += 500;
            }
            if (RightSide != null)
            {
                e.Graphics.DrawString("Pravá strana - " + RightSide.length.ToString() + "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) rightSidePartsValues = RightSide.CountParts();
                PrintSide(RightSide, rightSidePartsValues, start, e);
                start += 500;
            }
            // Graphics g = e.Graphics;
            // Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            // Brush brush = new SolidBrush(Color.Blue);
            // e.Graphics.DrawLine(pen, 20, 10, 300, 10);
            // e.Graphics.DrawRectangle(pen, 30, 30, 10, 230);
            // e.Graphics.FillRectangle(brush, 30, 30, 10, 230);
        }

        private void PrintSide(Side side, ((int count, int lenght) HL, (int count, int lenght) V, (int count, int lenght) VM, (int count, int lenght) HS, (int count, int lenght) BS, (int count, int lenght) VA, (int width, int height) glass) sidePartsValues, int start, PaintEventArgs e)
        {

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush greyBrush = new SolidBrush(Color.Gray);
            Font font1 = new Font("Microsoft Sans Serif", 17, FontStyle.Bold, GraphicsUnit.Pixel);

            // HL Count + Length with visualization
            int topStart = 80;
            start += 80;
            e.Graphics.DrawString("HL - " + sidePartsValues.HL.count.ToString() + "ks", font1, Brushes.Black, start + 15, topStart);
            e.Graphics.DrawString(sidePartsValues.HL.lenght.ToString() + "mm", font1, Brushes.Black, start + 15, topStart + 30);
            e.Graphics.DrawRectangle(pen, start + 15, topStart + 55, sidePartsValues.HL.lenght / 10, HLHeight);
            e.Graphics.FillRectangle(greyBrush, start + 15, topStart + 55, sidePartsValues.HL.lenght / 10, HLHeight);

            




            topStart += 75;
            start -= 80;
            // V Count + Length with visualization 
            e.Graphics.DrawString("V - " + sidePartsValues.V.count.ToString() + "ks", font1, Brushes.Black, start, ((sidePartsValues.V.lenght / 10) / 2 + (topStart - 25)));
            e.Graphics.DrawString(sidePartsValues.V.lenght.ToString() + "mm", font1, Brushes.Black, start, ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 5)));
            //e.Graphics.DrawLine(pen, 30, ((sidePartsValues.V.VLenght / 10) / 2 + 30), 200, ((sidePartsValues.V.VLenght / 10) / 2 + 30));
            start += 80;
            e.Graphics.DrawRectangle(pen, start, topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.FillRectangle(greyBrush, start, topStart, VWidth, sidePartsValues.V.lenght / 10);

            // down HL vizualization + glass width
            e.Graphics.DrawRectangle(pen, start + 15, topStart + 5 + (sidePartsValues.V.lenght / 10), sidePartsValues.HL.lenght / 10, HLHeight);
            e.Graphics.FillRectangle(greyBrush, start + 15, topStart + 5 + (sidePartsValues.V.lenght / 10), sidePartsValues.HL.lenght / 10, HLHeight);
            e.Graphics.DrawString("sklo - " + (sidePartsValues.HL.count / 2).ToString() + "ks", font1, Brushes.Blue, start + 15, topStart + (sidePartsValues.V.lenght / 10) + 30);
            e.Graphics.DrawString(sidePartsValues.glass.width.ToString() + "mm", font1, Brushes.Blue, start + 15, topStart + (sidePartsValues.V.lenght / 10) + 60);


            // VM Count + Length with visualization + glass height
            start += 10;
            e.Graphics.DrawRectangle(pen, start + 10 + (sidePartsValues.glass.width / 10), topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.FillRectangle(greyBrush, start + 10 + (sidePartsValues.glass.width / 10), topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.DrawString("VM - " + sidePartsValues.VM.count.ToString() + "ks", font1, Brushes.Black, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.VM.lenght / 10) / 2 + (topStart - 25)));
            e.Graphics.DrawString(sidePartsValues.VM.lenght.ToString() + "mm", font1, Brushes.Black, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.VM.lenght / 10) / 2 + (topStart + 5)));
            e.Graphics.DrawString("sklo - " + (sidePartsValues.HL.count / 2).ToString() + "ks", font1, Brushes.Blue, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 35)));
            e.Graphics.DrawString(sidePartsValues.glass.height.ToString() + "mm", font1, Brushes.Blue, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 65)));

            // Glass width + height with visualization
            e.Graphics.DrawRectangle(pen, start + 5, topStart + 5, sidePartsValues.glass.width / 10, sidePartsValues.glass.height / 10);
            e.Graphics.FillRectangle(blueBrush, start + 5, topStart + 5, sidePartsValues.glass.width / 10, sidePartsValues.glass.height / 10);
            //e.Graphics.DrawString("sklo", font1, Brushes.Black, start + 5, ((sidePartsValues.VM.lenght / 10) / 2 + (topStart - 25)));
            //e.Graphics.DrawString((sidePartsValues.HL.count / 2).ToString() + "ks", font1, Brushes.Black, start + 5, ((sidePartsValues.VM.lenght / 10) / 2 + (topStart + 5)));


        }
    }
}
