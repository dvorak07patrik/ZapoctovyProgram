using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZPProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // selecting default values for user
            leftSideDoorComboBox.SelectedIndex = 1;
            rightSideDoorComboBox.SelectedIndex = 1;
            midSideDoorComboBox.SelectedIndex = 2;
        }

        // takes side properties from Form and makes Side objects with them
        // 
        private void calculateButton_Click(object sender, EventArgs e)
        {
            Side leftSide = new Side(Convert.ToInt32(leftSideLength.Value), Convert.ToInt32(leftSideHeight.Value), leftSideDoorComboBox.SelectedIndex);
            Side rightSide = new Side(Convert.ToInt32(rightSideLength.Value), Convert.ToInt32(rightSideHeight.Value), rightSideDoorComboBox.SelectedIndex);
            Side midSide = new Side(Convert.ToInt32(midSideLength.Value), Convert.ToInt32(midSideHeight.Value), midSideDoorComboBox.SelectedIndex);
            // var leftSidePartsValues = leftSide.CountParts();
            // leftSideHLCountLabel.Text = leftSidePartsValues.Item1.Item1 + "ks";


            // checking if user inputs are valid and if they are not making the side null to not be more calculated or painted and showing error
            // ----------------------------------------------------------------------------
            if (leftSide.length / leftSide.numberOfDoors > 2000 || leftSide.length / leftSide.numberOfDoors < 500 || leftSide.height < 500 || leftSide.height > 3500 || leftSideDoorComboBox.SelectedIndex == -1)
            {
                if (leftSide.length / leftSide.numberOfDoors > 2000)
                {
                    leftSideErrorProvider.SetError(leftSideLength, "Tato hodnota je pro zvolený počet dveří příliš vysoká!");
                }
                if (leftSide.length / leftSide.numberOfDoors < 500)
                {
                    leftSideErrorProvider.SetError(leftSideLength, "Tato hodnota je pro zvolený počet dveří příliš nízká!");
                }
                if (leftSide.height < 500)
                {
                    leftSideErrorProvider.SetError(leftSideHeight, "Tato hodnota je příliš nízká!");
                }
                if (leftSide.height > 3500)
                {
                    leftSideErrorProvider.SetError(leftSideHeight, "Tato hodnota je příliš vysoká!");
                }
                if (leftSideDoorComboBox.SelectedIndex == -1)
                {
                    leftSideErrorProvider.SetError(leftSideDoorComboBox, "Tato hodnota je neplatná! Vyberte prosím jednu z variant.");
                }
                leftSide = null;
            }

            else 
            {
                var leftSideParstValues = leftSide.CountParts();
                showLeftSideOutputLabels(leftSide, leftSideParstValues);
                leftSideErrorProvider.SetError(leftSideLength, null);
                leftSideErrorProvider.SetError(leftSideHeight, null);
                leftSideErrorProvider.SetError(leftSideDoorComboBox, null);
            }

            if (rightSide.length / rightSide.numberOfDoors > 2000 || rightSide.length / rightSide.numberOfDoors < 500 || rightSide.height < 500 || rightSide.height > 3500 || rightSideDoorComboBox.SelectedIndex == -1)
            {
                if (rightSide.length / rightSide.numberOfDoors > 2000)
                {
                    rightSideErrorProvider.SetError(rightSideLength, "Tato hodnota je pro zvolený počet dveří příliš vysoká!");
                }
                if (rightSide.length / rightSide.numberOfDoors < 500)
                {
                    rightSideErrorProvider.SetError(rightSideLength, "Tato hodnota je pro zvolený počet dveří příliš nízká!");
                }
                if (rightSide.height < 500)
                {
                    rightSideErrorProvider.SetError(rightSideHeight, "Tato hodnota je příliš nízká!");
                }
                if (rightSide.height > 3500)
                {
                    rightSideErrorProvider.SetError(rightSideHeight, "Tato hodnota je příliš vysoká!");
                }
                if (rightSideDoorComboBox.SelectedIndex == -1)
                {
                    rightSideErrorProvider.SetError(rightSideDoorComboBox, "Tato hodnota je neplatná! Vyberte prosím jednu z variant.");
                }
                rightSide = null;
            }
            else
            {
                var rightSideParstValues = rightSide.CountParts();
                showRightSideOutputLabels(rightSide, rightSideParstValues);
                rightSideErrorProvider.SetError(rightSideLength, null);
                rightSideErrorProvider.SetError(rightSideHeight, null);
                rightSideErrorProvider.SetError(rightSideDoorComboBox, null);
            }

            if (midSide.length / midSide.numberOfDoors > 2000 || midSide.length / midSide.numberOfDoors < 500 || midSide.height < 500 || midSide.height > 3500 || midSideDoorComboBox.SelectedIndex == -1)
            {
                if (midSide.length / midSide.numberOfDoors > 2000)
                {
                    midSideErrorProvider.SetError(midSideLength, "Tato hodnota je pro zvolený počet dveří příliš vysoká!");
                }
                if (midSide.length / midSide.numberOfDoors < 500)
                {
                    midSideErrorProvider.SetError(midSideLength, "Tato hodnota je pro zvolený počet dveří příliš nízká!");
                }
                if (midSide.height < 500)
                {
                    midSideErrorProvider.SetError(midSideHeight, "Tato hodnota je příliš nízká!");
                }
                if (midSide.height > 3500)
                {
                    midSideErrorProvider.SetError(midSideHeight, "Tato hodnota je příliš vysoká!");
                }
                if (midSideDoorComboBox.SelectedIndex == -1)
                {
                    midSideErrorProvider.SetError(midSideDoorComboBox, "Tato hodnota je neplatná! Vyberte prosím jednu z variant.");
                }
                midSide = null;
            }
            else
            {
                var midSideParstValues = midSide.CountParts();
                showMidSideOutputLabels(midSide, midSideParstValues);
                midSideErrorProvider.SetError(midSideLength, null);
                midSideErrorProvider.SetError(midSideHeight, null);
                midSideErrorProvider.SetError(midSideDoorComboBox, null);
            }
            // --------------------------------------------------------------------------

            // creating and showing new Form for visualization of sides
            Form2 form2 = new Form2(leftSide, rightSide, midSide);
            form2.Show();
        }

        // functions for showing outputs of calculating side parts values
        // -----------------------------------------------------------------------------------------------------------
        private void showLeftSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) leftSidePartsValues)
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

            leftSideGlassHeightLabel.Text = "výška - " + leftSidePartsValues.Item7.Item2 + "mm";
            leftSideGlassWidthLabel.Text = "šířka - " + leftSidePartsValues.Item7.Item1 + "mm";
        }

        private void showRightSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) rightSidePartsValues)
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

            rightSideGlassHeightLabel.Text = "výška - " + rightSidePartsValues.Item7.Item2 + "mm";
            rightSideGlassWidthLabel.Text = "šířka - " + rightSidePartsValues.Item7.Item1 + "mm";
        }

        private void showMidSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) midSidePartsValues)
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

            midSideGlassHeightLabel.Text = "výška - " + midSidePartsValues.Item7.Item2 + "mm";
            midSideGlassWidthLabel.Text = "šířka - " + midSidePartsValues.Item7.Item1 + "mm";
        }
        // -----------------------------------------------------------------------------------------------------------
    }
}
