1) Introduction:
   This is a windows form application based on dotnet framework

2) Use of external classes:
   It uses Classes:
      1. Graphics
      2. Drawing
      4. Windows.Forms

3) Inside class:
   Class Side:
   stores Length (in milimeters), Height (in milimeters), DoorsComboIndex (NumberOfDoors) and has methods:
     1. CountParts() - return details for all parts with the help of other methods for counting parts
     2. Side() - constructor, assignes NumberOfDoors and Substractor (used in CountHL()) based on DoorsComboIndex
     3. getters for: Length, Width, NumberOfDoors
     4. functions for calculating each part

4) Form1:
   Contains NumericUpDown controls and ComboBoxes for user input with appropriate labels and button to start calculation. Function calculateButton_Click(object sender, EventArgs e) creates object for each side, validates user input and shows appropriate errors and
   calling object method for calculating parts and then changes labels with the help of functions (showMidSideOutputLabels(Side side, ((int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)) midSidePartsValues)) to show calculated values.
   This function also calls Form2.

6) Form2:
   Takes all three sices when called and then calls function Form2_Paint(object sender, PaintEventArgs e) which decides which side to show and than calls function
   PrintSide(Side side, ((int count, int lenght) HL, (int count, int lenght) V, (int count, int lenght) VM, (int count, int lenght) HS, (int count, int lenght) BS, (int count, int lenght) VA, (int width, int height) glass) sidePartsValues, int start, PaintEventArgs e) -
   this function prints with the help of class Graphics visualization of parts for doors
   
