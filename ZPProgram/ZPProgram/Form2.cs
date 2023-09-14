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
    public partial class WinterGardenVisualizationForm : Form
    {

        private Side LeftSide;
        private Side RightSide;
        private Side MidSide;
        private WinterGarden Garden;
        private int VWidth = 10;
        private int HLHeight = 15;
        private int HighestTopStart;

        // constructs Form2 variables
        public WinterGardenVisualizationForm(Side leftSide, Side rightSide, Side midSide, WinterGarden garden)
        {
            InitializeComponent();
            LeftSide = leftSide;
            RightSide = rightSide;
            MidSide = midSide;
            Garden = garden;
        }

        private void Form2_Resize(object sender, System.EventArgs e)
        {
            Form2_Paint(sender, (PaintEventArgs)e);
        }

        // paints 2D visualisation of sides
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            // without this condition are the last two conditions invalid (Form2_Paint runs twice sometimes)
            // if (Size.Width != 1493) { return; }


            // painting valid sides and decreasing form size if a side is not printed
            int printableSides = 0;
            int start = 30;
            Font font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold, GraphicsUnit.Pixel);
            HighestTopStart = 30;

            if (LeftSide.Length != 0)
            {
                e.Graphics.DrawString("Levá strana - " + LeftSide.Length.ToString()+ "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) leftSidePartsValues = LeftSide.CountParts();
                PrintSide(LeftSide, leftSidePartsValues, start, e);
                start += 500;
                printableSides += 1;
            }
            if (MidSide.Length != 0)
            {
                e.Graphics.DrawString("Prostřední strana - " + MidSide.Length.ToString() + "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) midSidePartsValues = MidSide.CountParts();
                PrintSide(MidSide, midSidePartsValues, start, e);
                start += 500;
                printableSides += 1;
                PrintBirdView(Garden, e);
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Prostřední strana a zimní zahrada shora nemohou být vykresleny !";
            }
            if (RightSide.Length != 0)
            {
                e.Graphics.DrawString("Pravá strana - " + RightSide.Length.ToString() + "mm", font, Brushes.Black, start, 30);
                ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) rightSidePartsValues = RightSide.CountParts();
                PrintSide(RightSide, rightSidePartsValues, start, e);
                start += 500;
                printableSides += 1;
            }
            if (printableSides < 1) 
            { 
                errorLabel.Visible = true;
                errorLabel.Text = "Žádná strana nemůže být vykreslena !";
            }
            else
            {
                PrintTriangle(Garden.Triangle, e);
            }


            
        }

        private void PrintSide(Side side, ((int count, int lenght) HL, (int count, int lenght) V, (int count, int lenght) VM, (int count, int lenght) HS, (int count, int lenght) BS, (int count, int lenght) VA, (int width, int height) glass) sidePartsValues, int start, PaintEventArgs e)
        {
            // declaration of pen, brushes and font variables
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

            // V Count + Length with visualization
            topStart += 75;
            start -= 80;
            e.Graphics.DrawString("V - " + sidePartsValues.V.count.ToString() + "ks", font1, Brushes.Black, start, ((sidePartsValues.V.lenght / 10) / 2 + (topStart - 25)));
            e.Graphics.DrawString(sidePartsValues.V.lenght.ToString() + "mm", font1, Brushes.Black, start, ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 5)));
            start += 80;
            e.Graphics.DrawRectangle(pen, start, topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.FillRectangle(greyBrush, start, topStart, VWidth, sidePartsValues.V.lenght / 10);

            // down HL visualization + glass width
            e.Graphics.DrawRectangle(pen, start + 15, topStart + 5 + (sidePartsValues.V.lenght / 10), sidePartsValues.HL.lenght / 10, HLHeight);
            e.Graphics.FillRectangle(greyBrush, start + 15, topStart + 5 + (sidePartsValues.V.lenght / 10), sidePartsValues.HL.lenght / 10, HLHeight);
            e.Graphics.DrawString("sklo - " + (sidePartsValues.HL.count / 2).ToString() + "ks", font1, blueBrush, start + 15, topStart + (sidePartsValues.V.lenght / 10) + 30);
            e.Graphics.DrawString(sidePartsValues.glass.width.ToString() + "mm", font1, blueBrush, start + 15, topStart + (sidePartsValues.V.lenght / 10) + 60);
            int topStartCheck = topStart + (sidePartsValues.V.lenght / 10) + 60;
            if (HighestTopStart < topStartCheck) 
            {
                HighestTopStart = topStartCheck;
            }


            // VM Count + Length with visualization + glass height
            start += 10;
            e.Graphics.DrawRectangle(pen, start + 10 + (sidePartsValues.glass.width / 10), topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.FillRectangle(greyBrush, start + 10 + (sidePartsValues.glass.width / 10), topStart, VWidth, sidePartsValues.V.lenght / 10);
            e.Graphics.DrawString("VM - " + sidePartsValues.VM.count.ToString() + "ks", font1, Brushes.Black, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.VM.lenght / 10) / 2 + (topStart - 55)));
            e.Graphics.DrawString(sidePartsValues.VM.lenght.ToString() + "mm", font1, Brushes.Black, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.VM.lenght / 10) / 2 + (topStart - 25)));
            e.Graphics.DrawString("sklo - " + (sidePartsValues.HL.count / 2).ToString() + "ks", font1, blueBrush, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 5)));
            e.Graphics.DrawString(sidePartsValues.glass.height.ToString() + "mm", font1, blueBrush, start + 30 + (sidePartsValues.glass.width / 10), ((sidePartsValues.V.lenght / 10) / 2 + (topStart + 35)));

            // Glass visualization
            e.Graphics.DrawRectangle(pen, start + 5, topStart + 5, sidePartsValues.glass.width / 10, sidePartsValues.glass.height / 10);
            e.Graphics.FillRectangle(blueBrush, start + 5, topStart + 5, sidePartsValues.glass.width / 10, sidePartsValues.glass.height / 10);

        }

        private void PrintTriangle(TriangleInfo triangle, PaintEventArgs e)
        {
            int start = 30;
            int topStart = HighestTopStart + 50;
            int rightPadding = 300;
            int downPadding = 100;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush greyBrush = new SolidBrush(Color.Gray);
            Font smallFont = new Font("Microsoft Sans Serif", 17, FontStyle.Bold, GraphicsUnit.Pixel);
            Font headerFont = new Font("Microsoft Sans Serif", 26, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics plain;
            plain = CreateGraphics();

            e.Graphics.DrawString("Skleněný trojúhelník", headerFont, Brushes.Black, start, topStart);
            topStart += 50;
            e.Graphics.DrawString(Math.Round(triangle.AngleAlpha, 4).ToString() + "°", smallFont,Brushes.Black,start + 40,topStart);
            topStart += 30;
            e.Graphics.DrawString(triangle.ShorterLeg.ToString() + "mm", smallFont, blueBrush, start, topStart + (downPadding / 3));
            start += 80;
            Point[] points = { new Point(start, topStart), new Point(start, topStart + downPadding), new Point(start + rightPadding, topStart + downPadding) };
            plain.FillPolygon(blueBrush,points);
            e.Graphics.DrawString(Math.Round(triangle.Hypotenuse, 1).ToString() + "mm", smallFont, blueBrush, start + ((rightPadding / 8) * 5), topStart + (downPadding / 3));
            topStart += downPadding;
            e.Graphics.DrawString(Math.Round(triangle.LongerLeg, 1).ToString() + "mm", smallFont, blueBrush, start + (rightPadding/3), topStart + 10);
            e.Graphics.DrawString(Math.Round(triangle.AngleBeta, 4).ToString() + "°", smallFont, Brushes.Black, start + rightPadding, topStart);
        }

        private void PrintBirdView(WinterGarden winterGarden, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush greyBrush = new SolidBrush(Color.Gray);
            Brush lowOpacityBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
            Font smallFont = new Font("Microsoft Sans Serif", 17, FontStyle.Bold, GraphicsUnit.Pixel);
            Font headerFont = new Font("Microsoft Sans Serif", 26, FontStyle.Bold, GraphicsUnit.Pixel);
            int rafterWidth = 10; 
            int start = 700;
            int topStart = HighestTopStart + 50;
            

            e.Graphics.DrawString("Zimní zahrada", headerFont, Brushes.Black, start, topStart);
            topStart += 50;

            e.Graphics.DrawString("délka skla", smallFont, blueBrush, start, topStart + (Convert.ToInt32(winterGarden.Length / 20)));
            e.Graphics.DrawString(Math.Round(winterGarden.RoofGlass.Length, 1).ToString()+"mm", smallFont, blueBrush, start, topStart + (Convert.ToInt32(winterGarden.Length / 20)) + 20);

            start += 100;
            int frontSideStart = start;

            // back side
            e.Graphics.DrawRectangle(pen, start, topStart, (Convert.ToInt32(winterGarden.Rafter.RafterSpacing / 10) + rafterWidth) * (winterGarden.Rafter.Count - 1) + rafterWidth, rafterWidth);
            e.Graphics.FillRectangle(greyBrush, start, topStart, (Convert.ToInt32(winterGarden.Rafter.RafterSpacing / 10) + rafterWidth) * (winterGarden.Rafter.Count - 1) + rafterWidth, rafterWidth);


            // rafters
            topStart += rafterWidth;
            e.Graphics.DrawRectangle(pen, start, topStart, rafterWidth, Convert.ToInt32(winterGarden.Rafter.Length / 10));
            e.Graphics.FillRectangle(greyBrush, start, topStart, rafterWidth, Convert.ToInt32(winterGarden.Rafter.Length / 10));
            for (int i = 0; i < winterGarden.Rafter.Count - 1; i++)
            {
                start += Convert.ToInt32(winterGarden.Rafter.RafterSpacing / 10) + rafterWidth;
                e.Graphics.DrawRectangle(pen, start, topStart, rafterWidth, Convert.ToInt32(winterGarden.Rafter.Length / 10));
                e.Graphics.FillRectangle(greyBrush, start, topStart, rafterWidth, Convert.ToInt32(winterGarden.Rafter.Length / 10));
            }
            topStart += Convert.ToInt32(winterGarden.Rafter.Length / 10);


            // front side
            e.Graphics.DrawRectangle(pen, frontSideStart, topStart, (Convert.ToInt32(winterGarden.Rafter.RafterSpacing / 10) + rafterWidth) * (winterGarden.Rafter.Count - 1) + rafterWidth, rafterWidth);
            e.Graphics.FillRectangle(greyBrush, frontSideStart, topStart, (Convert.ToInt32(winterGarden.Rafter.RafterSpacing / 10) + rafterWidth) * (winterGarden.Rafter.Count - 1) + rafterWidth, rafterWidth);


            // roof glass
            topStart -= Convert.ToInt32(winterGarden.Rafter.Length / 10) + rafterWidth;
            start = frontSideStart;
            start -= Convert.ToInt32(winterGarden.RoofGlass.SideOverlap / 10);
            e.Graphics.FillRectangle(lowOpacityBrush, start, topStart, Convert.ToInt32(winterGarden.RoofGlass.SideGlassWidth / 10), Convert.ToInt32(winterGarden.RoofGlass.Length / 10));
            // optional condition for better visualization of glass side overlap
            if (winterGarden.RoofGlass.SideGlassWidth % 10 != 0) 
            {
                start += Convert.ToInt32(winterGarden.RoofGlass.RafterSpace / 10) + Convert.ToInt32(winterGarden.RoofGlass.SideGlassWidth / 10) + 1;
            }
            else
            {
                start += Convert.ToInt32(winterGarden.RoofGlass.RafterSpace / 10) + Convert.ToInt32(winterGarden.RoofGlass.SideGlassWidth / 10);
            }
            // ________________________________________________________________
            for (int i = 0; i < winterGarden.RoofGlass.Count - 2; i++)
            {
                e.Graphics.FillRectangle(lowOpacityBrush, start, topStart, Convert.ToInt32(winterGarden.RoofGlass.MidGlassWidth / 10), Convert.ToInt32(winterGarden.RoofGlass.Length / 10));
                start += Convert.ToInt32(winterGarden.RoofGlass.RafterSpace / 10) + Convert.ToInt32(winterGarden.RoofGlass.MidGlassWidth / 10);
            }
            e.Graphics.FillRectangle(lowOpacityBrush, start, topStart, Convert.ToInt32(winterGarden.RoofGlass.SideGlassWidth / 10), Convert.ToInt32(winterGarden.RoofGlass.Length / 10));


            // glass width parameters
            topStart += Convert.ToInt32(winterGarden.RoofGlass.Length / 10);
            start = frontSideStart;
            e.Graphics.DrawString("boční sklo", smallFont, blueBrush, start, topStart);
            e.Graphics.DrawString("2 ks", smallFont, blueBrush, start, topStart + 20);
            e.Graphics.DrawString(Math.Round(winterGarden.RoofGlass.SideGlassWidth).ToString() +"mm", smallFont, blueBrush, start, topStart + 40);
            start += Convert.ToInt32(winterGarden.RoofGlass.RafterSpace / 10) + Convert.ToInt32(winterGarden.RoofGlass.SideGlassWidth / 10) + 1;
            e.Graphics.DrawString("prostřední sklo", smallFont, blueBrush, start, topStart);
            e.Graphics.DrawString((winterGarden.RoofGlass.Count - 2).ToString()+" ks", smallFont, blueBrush, start, topStart + 20);
            e.Graphics.DrawString(Math.Round(winterGarden.RoofGlass.MidGlassWidth).ToString() + "mm", smallFont, blueBrush, start, topStart + 40);

        }
    }
}
