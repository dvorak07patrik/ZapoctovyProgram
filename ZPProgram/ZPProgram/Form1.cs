using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            // for left side
            if (tryIt(leftSideErrorProvider, leftSideLength, leftSideHeight, leftSide, leftSideDoorComboBox) == true)
            {
                var leftSideParstValues = leftSide.CountParts();
                showLeftSideOutputLabels(leftSide, leftSideParstValues);
            }
            else
            {
                leftSide = null;
            }

            // for right side
            if (tryIt(rightSideErrorProvider, rightSideLength, rightSideHeight, rightSide, rightSideDoorComboBox) == true)
            {
                var rightSideParstValues = rightSide.CountParts();
                showRightSideOutputLabels(rightSide, rightSideParstValues);
            }
            else
            {
                rightSide = null;
            }

            // for mid side
            if (tryIt(midSideErrorProvider, midSideLength, midSideHeight, midSide, midSideDoorComboBox) == true)
            {
                var midSideParstValues = midSide.CountParts();
                showMidSideOutputLabels(midSide, midSideParstValues);
            }
            else
            {
                midSide = null;
            }
            // --------------------------------------------------------------------------


            // creating and showing new Form for visualization of sides
            Form2 form2 = new Form2(leftSide, rightSide, midSide);
            form2.Show();
        }

        // else if not used to show all of the errors
        private bool tryIt(ErrorProvider sideErrorProvider, NumericUpDown sideLength, NumericUpDown sideHeight, Side side, System.Windows.Forms.ComboBox sideDoorComboBox)
        {
            bool check = true; 
            if (side.length / side.numberOfDoors > 2000)
            {
                sideErrorProvider.SetError(sideLength, "Tato hodnota je pro zvolený počet dveří příliš vysoká!");
                check = false;
            }
            if (side.length / side.numberOfDoors < 500)
            {
                sideErrorProvider.SetError(sideLength, "Tato hodnota je pro zvolený počet dveří příliš nízká!");
                check = false;
            }
            if (side.height < 500)
            {
                sideErrorProvider.SetError(sideHeight, "Tato hodnota je příliš nízká!");
                check = false;
            }
            if (side.height > 3500)
            {
                sideErrorProvider.SetError(sideHeight, "Tato hodnota je příliš vysoká!");
                check = false;
            }
            if (sideDoorComboBox.SelectedIndex == -1)
            {
                sideErrorProvider.SetError(sideDoorComboBox, "Tato hodnota je neplatná! Vyberte prosím jednu z variant.");
                check = false;
            }
            if (check == false)
            {
                return check;
            }
            else
            {
                sideErrorProvider.SetError(sideLength, null);
                sideErrorProvider.SetError(sideHeight, null);
                sideErrorProvider.SetError(sideDoorComboBox, null);
                return check;
            }
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
