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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Side leftSide = new Side(Convert.ToInt32(leftSideLength.Value), Convert.ToInt32(leftSideHeight.Value), Convert.ToInt32(leftSideDoorCount.Value));
            Side rightSide = new Side(Convert.ToInt32(rightSideLength.Value), Convert.ToInt32(rightSideHeight.Value), Convert.ToInt32(rightSideDoorCount.Value));
            Side midSide = new Side(Convert.ToInt32(midSideLength.Value), Convert.ToInt32(midSideHeight.Value), Convert.ToInt32(midSideDoorCount.Value));
            var nevim = LeftSideDoorComboBox.SelectedIndex;
            var leftSidePartsValues = leftSide.CountParts();
            leftSideHLCountLabel.Text = leftSidePartsValues.Item1.Item1 + "ks";
        }
    }
}
