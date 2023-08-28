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
            Side leftSide = new Side(Convert.ToInt32(leftSideLength.Value), Convert.ToInt32(leftSideHeight.Value), leftSideDoorComboBox.SelectedIndex);
            Side rightSide = new Side(Convert.ToInt32(rightSideLength.Value), Convert.ToInt32(rightSideHeight.Value), rightSideDoorComboBox.SelectedIndex);
            Side midSide = new Side(Convert.ToInt32(midSideLength.Value), Convert.ToInt32(midSideHeight.Value), midSideDoorComboBox.SelectedIndex);
            var nevim = leftSideDoorComboBox.SelectedIndex;
            // var leftSidePartsValues = leftSide.CountParts();
            // leftSideHLCountLabel.Text = leftSidePartsValues.Item1.Item1 + "ks";

            var leftSideParstValues = leftSide.CountParts();
            var rightSideParstValues = rightSide.CountParts();
            var midSideParstValues = midSide.CountParts();
            showLeftSideOutputLabels(leftSide, leftSideParstValues);
            showRightSideOutputLabels(rightSide, rightSideParstValues);
            showMidSideOutputLabels(midSide, midSideParstValues);

            Form2 form2 = new Form2(leftSide, rightSide, midSide);
            form2.Show();
        }

        private void showLeftSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) leftSidePartsValues)
        {
            leftSideHLCountLabel.Text = leftSidePartsValues.Item1.Item1 + "ks";
            leftSideHLLengthLabel.Text = leftSidePartsValues.Item1.Item2 + "mm";

            leftSideVCountLabel.Text = leftSidePartsValues.Item2.Item1 + "ks";
            leftSideVLengthLabel.Text = leftSidePartsValues.Item2.Item2 + "mm";

            leftSideVMCountLabel.Text = leftSidePartsValues.Item3.Item1 + "ks";
            leftSideVMLengthLabel.Text = leftSidePartsValues.Item3.Item2 + "mm";

            leftSideHSCountLabel.Text = leftSidePartsValues.Item4.Item1 + "ks";
            leftSideHSLengthLabel.Text = leftSidePartsValues.Item4.Item2 + "mm";

            leftSideBSCountLabel.Text = leftSidePartsValues.Item5.Item1 + "ks";
            leftSideBSLengthLabel.Text = leftSidePartsValues.Item5.Item2 + "mm";

            leftSideVACountLabel.Text = leftSidePartsValues.Item6.Item1 + "ks";
            leftSideVALengthLabel.Text = leftSidePartsValues.Item6.Item2 + "mm";
        }

        private void showRightSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) rightSidePartsValues)
        {
            rightSideHLCountLabel.Text = rightSidePartsValues.Item1.Item1 + "ks";
            rightSideHLLengthLabel.Text = rightSidePartsValues.Item1.Item2 + "mm";

            rightSideVCountLabel.Text = rightSidePartsValues.Item2.Item1 + "ks";
            rightSideVLengthLabel.Text = rightSidePartsValues.Item2.Item2 + "mm";

            rightSideVMCountLabel.Text = rightSidePartsValues.Item3.Item1 + "ks";
            rightSideVMLengthLabel.Text = rightSidePartsValues.Item3.Item2 + "mm";

            rightSideHSCountLabel.Text = rightSidePartsValues.Item4.Item1 + "ks";
            rightSideHSLengthLabel.Text = rightSidePartsValues.Item4.Item2 + "mm";

            rightSideBSCountLabel.Text = rightSidePartsValues.Item5.Item1 + "ks";
            rightSideBSLengthLabel.Text = rightSidePartsValues.Item5.Item2 + "mm";

            rightSideVACountLabel.Text = rightSidePartsValues.Item6.Item1 + "ks";
            rightSideVALengthLabel.Text = rightSidePartsValues.Item6.Item2 + "mm";
        }

        private void showMidSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) midSidePartsValues)
        { 
            midSideHLCountLabel.Text = midSidePartsValues.Item1.Item1 + "ks";
            midSideHLLengthLabel.Text = midSidePartsValues.Item1.Item2 + "mm";

            midSideVCountLabel.Text = midSidePartsValues.Item2.Item1 + "ks";
            midSideVLengthLabel.Text = midSidePartsValues.Item2.Item2 + "mm";

            midSideVMCountLabel.Text = midSidePartsValues.Item3.Item1 + "ks";
            midSideVMLengthLabel.Text = midSidePartsValues.Item3.Item2 + "mm";

            midSideHSCountLabel.Text = midSidePartsValues.Item4.Item1 + "ks";
            midSideHSLengthLabel.Text = midSidePartsValues.Item4.Item2 + "mm";

            midSideBSCountLabel.Text = midSidePartsValues.Item5.Item1 + "ks";
            midSideBSLengthLabel.Text = midSidePartsValues.Item5.Item2 + "mm";

            midSideVACountLabel.Text = midSidePartsValues.Item6.Item1 + "ks";
            midSideVALengthLabel.Text = midSidePartsValues.Item6.Item2 + "mm";
        }
    }
}
