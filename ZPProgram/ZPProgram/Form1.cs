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
    public partial class WinterGardenCalculatorForm : Form
    {
        public WinterGardenCalculatorForm()
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
            if (validateSide(leftSideErrorProvider, leftSideLength, leftSideHeight, leftSide, leftSideDoorComboBox) == true)
            {
                var leftSideParstValues = leftSide.CountParts();
                showLeftSideOutputLabels(leftSide, leftSideParstValues);
            }
            else
            {
                leftSide.Length = 0;
            }

            // for right side
            if (validateSide(rightSideErrorProvider, rightSideLength, rightSideHeight, rightSide, rightSideDoorComboBox) == true)
            {
                var rightSideParstValues = rightSide.CountParts();
                showRightSideOutputLabels(rightSide, rightSideParstValues);
            }
            else
            {
                rightSide.Length = 0;
            }

            // for mid side
            if (validateSide(midSideErrorProvider, midSideLength, midSideHeight, midSide, midSideDoorComboBox) == true)
            {
                var midSideParstValues = midSide.CountParts();
                showMidSideOutputLabels(midSide, midSideParstValues);
            }
            else
            {
                midSide.Length = 0;
            }
            // --------------------------------------------------------------------------

            

            // making WinterGarden object based on longest side
            double longestSide;
            double highestHeight;
            if (leftSide.Length > rightSide.Length)
            {
                longestSide = leftSide.Length;
            }
            else
            {
                longestSide = rightSide.Length;
            }
            if (leftSide.Height >= rightSide.Height && leftSide.Height >= midSide.Height) 
            {
                highestHeight = leftSide.Height;
            }
            else if (rightSide.Height >= midSide.Height)
            {
                highestHeight = rightSide.Height;
            }
            else
            {
                highestHeight = midSide.Height;
            }

            int rafterWidth = 100;
            

            // longestSide + 200 for two joists width and midSide.Length + 200 for two joists width
            WinterGarden winterGarden = new WinterGarden(longestSide + 2 * (rafterWidth), midSide.Length + (2 * rafterWidth), Convert.ToDouble(backSideHeight.Value), highestHeight);
            winterGarden.CalculateRoof();
            if (leftSide.Length != 0 || rightSide.Length != 0) { showRafterOutputLabels(winterGarden.Rafter); }


            // creating and showing new Form for visualization of sides
            WinterGardenVisualizationForm form2 = new WinterGardenVisualizationForm(leftSide, rightSide, midSide, winterGarden);
            form2.Show();
        }

        // validates side and shows errors for the user
        // else if not used to show all of the errors
        private bool validateSide(ErrorProvider sideErrorProvider, NumericUpDown sideLength, NumericUpDown sideHeight, Side side, System.Windows.Forms.ComboBox sideDoorComboBox)
        {
            int maxDoorLength = 2000;
            int minDoorLength = 500;
            int minDoorHeight = 500;
            int maxDoorHeigth = 3500;

            bool check = true; 
            if (side.Length / side.NumberOfDoors > maxDoorLength)
            {
                sideErrorProvider.SetError(sideLength, "Tato hodnota je pro zvolený počet dveří příliš vysoká!");
                check = false;
            }
            if (side.Length / side.NumberOfDoors < minDoorLength)
            {
                sideErrorProvider.SetError(sideLength, "Tato hodnota je pro zvolený počet dveří příliš nízká!");
                check = false;
            }
            if (side.Height < minDoorHeight)
            {
                sideErrorProvider.SetError(sideHeight, "Tato hodnota je příliš nízká!");
                check = false;
            }
            if (side.Height > maxDoorHeigth)
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
        private void showLeftSideOutputLabels(Side side, ((int Count, int Length) HL, (int Count, int Length) V, (int Count, int Length) VM, (int Count, int Length) BS, (int Count, int Length) HS, (int Count, int Length) VA, (int Width, int Height) Glass) leftSidePartsValues)
        {
            leftSideHLCountLabel.Text = leftSidePartsValues.HL.Count + "ks";
            leftSideHLLengthLabel.Text = leftSidePartsValues.HL.Length + "mm";

            leftSideVCountLabel.Text = leftSidePartsValues.V.Count + "ks";
            leftSideVLengthLabel.Text = leftSidePartsValues.V.Length + "mm";

            leftSideVMCountLabel.Text = leftSidePartsValues.VM.Count + "ks";
            leftSideVMLengthLabel.Text = leftSidePartsValues.VM.Length + "mm";

            leftSideHSCountLabel.Text = leftSidePartsValues.BS.Count + "ks";
            leftSideHSLengthLabel.Text = leftSidePartsValues.BS.Length + "mm";

            leftSideBSCountLabel.Text = leftSidePartsValues.HS.Count + "ks";
            leftSideBSLengthLabel.Text = leftSidePartsValues.HS.Length + "mm";

            leftSideVACountLabel.Text = leftSidePartsValues.VA.Count + "ks";
            leftSideVALengthLabel.Text = leftSidePartsValues.VA.Length + "mm";

            leftSideGlassHeightLabel.Text = "výška - " + leftSidePartsValues.Glass.Height + "mm";
            leftSideGlassWidthLabel.Text = "šířka - " + leftSidePartsValues.Glass.Width + "mm";
        }

        private void showRightSideOutputLabels(Side side, ((int Count, int Length) HL, (int Count, int Length) V, (int Count, int Length) VM, (int Count, int Length) BS, (int Count, int Length) HS, (int Count, int Length) VA, (int Width, int Height) Glass) rightSidePartsValues)
        {
            rightSideHLCountLabel.Text = rightSidePartsValues.HL.Count + "ks";
            rightSideHLLengthLabel.Text = rightSidePartsValues.HL.Length + "mm";

            rightSideVCountLabel.Text = rightSidePartsValues.V.Count + "ks";
            rightSideVLengthLabel.Text = rightSidePartsValues.V.Length + "mm";

            rightSideVMCountLabel.Text = rightSidePartsValues.VM.Count + "ks";
            rightSideVMLengthLabel.Text = rightSidePartsValues.VM.Length + "mm";

            rightSideHSCountLabel.Text = rightSidePartsValues.BS.Count + "ks";
            rightSideHSLengthLabel.Text = rightSidePartsValues.BS.Length + "mm";

            rightSideBSCountLabel.Text = rightSidePartsValues.HS.Count + "ks";
            rightSideBSLengthLabel.Text = rightSidePartsValues.HS.Length + "mm";

            rightSideVACountLabel.Text = rightSidePartsValues.VA.Count + "ks";
            rightSideVALengthLabel.Text = rightSidePartsValues.VA.Length + "mm";

            rightSideGlassHeightLabel.Text = "výška - " + rightSidePartsValues.Glass.Height + "mm";
            rightSideGlassWidthLabel.Text = "šířka - " + rightSidePartsValues.Glass.Width + "mm";
        }

        private void showMidSideOutputLabels(Side side, ((int Count, int Length) HL, (int Count, int Length) V, (int Count, int Length) VM, (int Count, int Length) BS, (int Count, int Length) HS, (int Count, int Length) VA, (int Width, int Height) Glass) midSidePartsValues)
        { 
            midSideHLCountLabel.Text = midSidePartsValues.HL.Count + "ks";
            midSideHLLengthLabel.Text = midSidePartsValues.HL.Length + "mm";

            midSideVCountLabel.Text = midSidePartsValues.V.Count + "ks";
            midSideVLengthLabel.Text = midSidePartsValues.V.Length + "mm";

            midSideVMCountLabel.Text = midSidePartsValues.VM.Count + "ks";
            midSideVMLengthLabel.Text = midSidePartsValues.VM.Length + "mm";

            midSideHSCountLabel.Text = midSidePartsValues.BS.Count + "ks";
            midSideHSLengthLabel.Text = midSidePartsValues.BS.Length + "mm";

            midSideBSCountLabel.Text = midSidePartsValues.HS.Count + "ks";
            midSideBSLengthLabel.Text = midSidePartsValues.HS.Length + "mm";

            midSideVACountLabel.Text = midSidePartsValues.VA.Count + "ks";
            midSideVALengthLabel.Text = midSidePartsValues.VA.Length + "mm";

            midSideGlassHeightLabel.Text = "výška - " + midSidePartsValues.Glass.Height + "mm";
            midSideGlassWidthLabel.Text = "šířka - " + midSidePartsValues.Glass.Width + "mm";
        }
        // -----------------------------------------------------------------------------------------------------------

        private void showRafterOutputLabels(RafterInfo rafter)
        {
            rafterCountLabel.Text = "Krov - " + rafter.Count.ToString() + " ks";
            rafterAngleLabel.Text = "Úhel řezu: " + Math.Round(rafter.Angle, 2).ToString();
            rafterLengthLabel.Text = "Délka: " + Math.Round(rafter.Length, 1).ToString() + "mm";
        }
    }
}
