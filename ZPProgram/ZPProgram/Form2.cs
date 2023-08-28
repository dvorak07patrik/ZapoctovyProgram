using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPProgram
{
    public partial class Form2 : Form
    {
        public Form2(Side leftSide, Side rightSide, Side midSide)
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Brush brush = new SolidBrush(Color.Blue);
            e.Graphics.DrawLine(pen, 20, 10, 300, 10);
            e.Graphics.DrawRectangle(pen, 30, 30, 100, 200);
            e.Graphics.FillRectangle(brush, 30, 30, 100, 200);

        }
    }
}
