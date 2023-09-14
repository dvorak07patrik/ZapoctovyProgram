1) Introduction:
   Welcome to ZPProgram, a powerful tool designed to help you calculate and visualize the components required for glazing your winter garden.
   This user guide will walk you through the installation process, using the calculator, and viewing the visualization.
   
2) System Requirements:
   1. Operating System: Windows (10, 11)
   2. .NET Framework 4.7.2 or later
   3. Graphics Card and Monitor that support a minimum resolution of 1920x1080

3) Launch:
   To launch the program simply open ZPProgram/bin/Debug/ZPProgram.exe

4) User Interference overview:

   Upon launching ZPProgram, you will be greeted with the main user interface containing input fields and button. The interface consists of
   the following elements:

   1. Input fields for specifying the dimensions of each side of the winter garden.
   2. Dropdown menu to select the number of doors of each side of the winter garden.
   3. "Spočítej" button to trigger the calculation.

5) Using the calculator:
   1. Input the dimensions of each side of the winter garden in the provided input fields (if you dont need that side write 0 to Height or Length field)
      Length and Height are in milimeters
   2. Select the desired number of doors from the dropdown menu.
   3. Click the "Spočítej" button to perform the calculations.

6) Viewing the Result:

   After the button click new window will pop-up. The window shows you visualization of components for each winter garden side with their details.
   First Window also fills the components details.
   If you want to change input dimensions just switch to the first window, change your dimensions and click the button "Spočítej". New window will
   pop-up so you can compare it to the first one and so on.
   Parts:
   HL - HL is on the top and on the buttom of the door and rides inside of BS and HS for doors to be movable
   V - V part goes inside VA part in the system and is always just on one side of the door
   VM - VM part in on one side of door or on each side and catches VM on other door to move more door at once
   HS - HS part is a top rail part where doors move
   BS - BS part is a bottom rail part where doors move
   VA - VA is a bar in which goes V part of the door
   Glass - glass surrounded by HL on the top and buttom and VM and V on sides

8) Result did not appear:

   If there is a side missing in a visualization and also first pages component list of that side contains default values there is a problem in
   your input. A little Error will pop-up at yours wrong input so you can fix it.
   Some of the errors could be:
      1) The height value is too low.
      2) The value for number of doors is invalid! Choose value from dropdown menu.
      3) The length value is too large for chosen number of doors.
