namespace ZPProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftSideLength = new System.Windows.Forms.NumericUpDown();
            this.LeftSideLengthLabel = new System.Windows.Forms.Label();
            this.leftSideLabel = new System.Windows.Forms.Label();
            this.rightSideLabel = new System.Windows.Forms.Label();
            this.RightSideLengthLabel = new System.Windows.Forms.Label();
            this.rightSideLength = new System.Windows.Forms.NumericUpDown();
            this.midSideLength = new System.Windows.Forms.NumericUpDown();
            this.MidSideLengthLabel = new System.Windows.Forms.Label();
            this.MidSideLabel = new System.Windows.Forms.Label();
            this.midSideHeight = new System.Windows.Forms.NumericUpDown();
            this.rightSideHeight = new System.Windows.Forms.NumericUpDown();
            this.leftSideHeight = new System.Windows.Forms.NumericUpDown();
            this.MidSideHeightLabel = new System.Windows.Forms.Label();
            this.RightSideHeightLabel = new System.Windows.Forms.Label();
            this.LeftSideHeightLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.midSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.rightSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.leftSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.midSideDoorCountLabel = new System.Windows.Forms.Label();
            this.rightSideDoorCountLabel = new System.Windows.Forms.Label();
            this.leftSideDoorCountLabel = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leftDoorCountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.splitter8 = new System.Windows.Forms.Splitter();
            this.leftSideHL = new System.Windows.Forms.Label();
            this.VLabel = new System.Windows.Forms.Label();
            this.VMLabel = new System.Windows.Forms.Label();
            this.HSLabel = new System.Windows.Forms.Label();
            this.BSLabel = new System.Windows.Forms.Label();
            this.VALabel = new System.Windows.Forms.Label();
            this.leftSideHLCountLabel = new System.Windows.Forms.Label();
            this.leftSideVCountLabel = new System.Windows.Forms.Label();
            this.leftSideVMCountLabel = new System.Windows.Forms.Label();
            this.leftSideHSCountLabel = new System.Windows.Forms.Label();
            this.leftSideBSCountLabel = new System.Windows.Forms.Label();
            this.leftSideVACountLabel = new System.Windows.Forms.Label();
            this.leftSideHLLengthLabel = new System.Windows.Forms.Label();
            this.leftSideVLengthLabel = new System.Windows.Forms.Label();
            this.leftSideVMLengthLabel = new System.Windows.Forms.Label();
            this.leftSideHSLengthLabel = new System.Windows.Forms.Label();
            this.leftSideBSLengthLabel = new System.Windows.Forms.Label();
            this.leftSideVALengthLabel = new System.Windows.Forms.Label();
            this.LeftSideDoorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midSideDoorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorCountErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSideLength
            // 
            this.leftSideLength.BackColor = System.Drawing.SystemColors.Window;
            this.leftSideLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftSideLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.leftSideLength.Location = new System.Drawing.Point(13, 90);
            this.leftSideLength.Margin = new System.Windows.Forms.Padding(7);
            this.leftSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.leftSideLength.Name = "leftSideLength";
            this.leftSideLength.Size = new System.Drawing.Size(280, 28);
            this.leftSideLength.TabIndex = 0;
            // 
            // LeftSideLengthLabel
            // 
            this.LeftSideLengthLabel.AutoSize = true;
            this.LeftSideLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftSideLengthLabel.Location = new System.Drawing.Point(9, 60);
            this.LeftSideLengthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LeftSideLengthLabel.Name = "LeftSideLengthLabel";
            this.LeftSideLengthLabel.Size = new System.Drawing.Size(133, 20);
            this.LeftSideLengthLabel.TabIndex = 1;
            this.LeftSideLengthLabel.Text = "Délka levé strany:";
            // 
            // leftSideLabel
            // 
            this.leftSideLabel.AutoSize = true;
            this.leftSideLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideLabel.Location = new System.Drawing.Point(7, 10);
            this.leftSideLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.leftSideLabel.Name = "leftSideLabel";
            this.leftSideLabel.Size = new System.Drawing.Size(119, 33);
            this.leftSideLabel.TabIndex = 2;
            this.leftSideLabel.Text = "Levá strana";
            // 
            // rightSideLabel
            // 
            this.rightSideLabel.AutoSize = true;
            this.rightSideLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightSideLabel.Location = new System.Drawing.Point(7, 160);
            this.rightSideLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.rightSideLabel.Name = "rightSideLabel";
            this.rightSideLabel.Size = new System.Drawing.Size(129, 33);
            this.rightSideLabel.TabIndex = 5;
            this.rightSideLabel.Text = "Pravá strana";
            // 
            // RightSideLengthLabel
            // 
            this.RightSideLengthLabel.AutoSize = true;
            this.RightSideLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightSideLengthLabel.Location = new System.Drawing.Point(9, 210);
            this.RightSideLengthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RightSideLengthLabel.Name = "RightSideLengthLabel";
            this.RightSideLengthLabel.Size = new System.Drawing.Size(144, 20);
            this.RightSideLengthLabel.TabIndex = 6;
            this.RightSideLengthLabel.Text = "Délka pravé strany:";
            // 
            // rightSideLength
            // 
            this.rightSideLength.BackColor = System.Drawing.SystemColors.Window;
            this.rightSideLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rightSideLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rightSideLength.Location = new System.Drawing.Point(13, 240);
            this.rightSideLength.Margin = new System.Windows.Forms.Padding(7);
            this.rightSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.rightSideLength.Name = "rightSideLength";
            this.rightSideLength.Size = new System.Drawing.Size(280, 28);
            this.rightSideLength.TabIndex = 7;
            // 
            // midSideLength
            // 
            this.midSideLength.BackColor = System.Drawing.SystemColors.Window;
            this.midSideLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.midSideLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.midSideLength.Location = new System.Drawing.Point(13, 390);
            this.midSideLength.Margin = new System.Windows.Forms.Padding(7);
            this.midSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.midSideLength.Name = "midSideLength";
            this.midSideLength.Size = new System.Drawing.Size(280, 28);
            this.midSideLength.TabIndex = 10;
            // 
            // MidSideLengthLabel
            // 
            this.MidSideLengthLabel.AutoSize = true;
            this.MidSideLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MidSideLengthLabel.Location = new System.Drawing.Point(9, 360);
            this.MidSideLengthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MidSideLengthLabel.Name = "MidSideLengthLabel";
            this.MidSideLengthLabel.Size = new System.Drawing.Size(176, 20);
            this.MidSideLengthLabel.TabIndex = 9;
            this.MidSideLengthLabel.Text = "Délka prostřední strany:";
            // 
            // MidSideLabel
            // 
            this.MidSideLabel.AutoSize = true;
            this.MidSideLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MidSideLabel.Location = new System.Drawing.Point(7, 310);
            this.MidSideLabel.Name = "MidSideLabel";
            this.MidSideLabel.Size = new System.Drawing.Size(170, 33);
            this.MidSideLabel.TabIndex = 8;
            this.MidSideLabel.Text = "Prostřední strana";
            // 
            // midSideHeight
            // 
            this.midSideHeight.BackColor = System.Drawing.SystemColors.Window;
            this.midSideHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.midSideHeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.midSideHeight.Location = new System.Drawing.Point(344, 390);
            this.midSideHeight.Margin = new System.Windows.Forms.Padding(7);
            this.midSideHeight.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.midSideHeight.Name = "midSideHeight";
            this.midSideHeight.Size = new System.Drawing.Size(280, 28);
            this.midSideHeight.TabIndex = 11;
            // 
            // rightSideHeight
            // 
            this.rightSideHeight.BackColor = System.Drawing.SystemColors.Window;
            this.rightSideHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rightSideHeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rightSideHeight.Location = new System.Drawing.Point(344, 240);
            this.rightSideHeight.Margin = new System.Windows.Forms.Padding(7);
            this.rightSideHeight.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.rightSideHeight.Name = "rightSideHeight";
            this.rightSideHeight.Size = new System.Drawing.Size(280, 28);
            this.rightSideHeight.TabIndex = 11;
            // 
            // leftSideHeight
            // 
            this.leftSideHeight.BackColor = System.Drawing.SystemColors.Window;
            this.leftSideHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftSideHeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.leftSideHeight.Location = new System.Drawing.Point(344, 90);
            this.leftSideHeight.Margin = new System.Windows.Forms.Padding(7);
            this.leftSideHeight.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.leftSideHeight.Name = "leftSideHeight";
            this.leftSideHeight.Size = new System.Drawing.Size(280, 28);
            this.leftSideHeight.TabIndex = 11;
            // 
            // MidSideHeightLabel
            // 
            this.MidSideHeightLabel.AutoSize = true;
            this.MidSideHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MidSideHeightLabel.Location = new System.Drawing.Point(340, 360);
            this.MidSideHeightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MidSideHeightLabel.Name = "MidSideHeightLabel";
            this.MidSideHeightLabel.Size = new System.Drawing.Size(178, 20);
            this.MidSideHeightLabel.TabIndex = 11;
            this.MidSideHeightLabel.Text = "Výška prostřední strany:";
            // 
            // RightSideHeightLabel
            // 
            this.RightSideHeightLabel.AutoSize = true;
            this.RightSideHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightSideHeightLabel.Location = new System.Drawing.Point(340, 210);
            this.RightSideHeightLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RightSideHeightLabel.Name = "RightSideHeightLabel";
            this.RightSideHeightLabel.Size = new System.Drawing.Size(146, 20);
            this.RightSideHeightLabel.TabIndex = 12;
            this.RightSideHeightLabel.Text = "Výška pravé strany:";
            // 
            // LeftSideHeightLabel
            // 
            this.LeftSideHeightLabel.AutoSize = true;
            this.LeftSideHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftSideHeightLabel.Location = new System.Drawing.Point(340, 60);
            this.LeftSideHeightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LeftSideHeightLabel.Name = "LeftSideHeightLabel";
            this.LeftSideHeightLabel.Size = new System.Drawing.Size(135, 20);
            this.LeftSideHeightLabel.TabIndex = 11;
            this.LeftSideHeightLabel.Text = "Výška levé strany:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LeftSideDoorComboBox);
            this.panel1.Controls.Add(this.midSideDoorCount);
            this.panel1.Controls.Add(this.rightSideDoorCount);
            this.panel1.Controls.Add(this.leftSideDoorCount);
            this.panel1.Controls.Add(this.midSideDoorCountLabel);
            this.panel1.Controls.Add(this.rightSideDoorCountLabel);
            this.panel1.Controls.Add(this.leftSideDoorCountLabel);
            this.panel1.Controls.Add(this.midSideHeight);
            this.panel1.Controls.Add(this.midSideLength);
            this.panel1.Controls.Add(this.MidSideHeightLabel);
            this.panel1.Controls.Add(this.rightSideHeight);
            this.panel1.Controls.Add(this.leftSideLabel);
            this.panel1.Controls.Add(this.leftSideHeight);
            this.panel1.Controls.Add(this.RightSideHeightLabel);
            this.panel1.Controls.Add(this.MidSideLengthLabel);
            this.panel1.Controls.Add(this.LeftSideLengthLabel);
            this.panel1.Controls.Add(this.MidSideLabel);
            this.panel1.Controls.Add(this.LeftSideHeightLabel);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.rightSideLength);
            this.panel1.Controls.Add(this.leftSideLength);
            this.panel1.Controls.Add(this.RightSideLengthLabel);
            this.panel1.Controls.Add(this.rightSideLabel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 503);
            this.panel1.TabIndex = 12;
            // 
            // midSideDoorCount
            // 
            this.midSideDoorCount.BackColor = System.Drawing.SystemColors.Window;
            this.midSideDoorCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.midSideDoorCount.Location = new System.Drawing.Point(674, 390);
            this.midSideDoorCount.Margin = new System.Windows.Forms.Padding(7);
            this.midSideDoorCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.midSideDoorCount.Name = "midSideDoorCount";
            this.midSideDoorCount.Size = new System.Drawing.Size(280, 28);
            this.midSideDoorCount.TabIndex = 18;
            // 
            // rightSideDoorCount
            // 
            this.rightSideDoorCount.BackColor = System.Drawing.SystemColors.Window;
            this.rightSideDoorCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rightSideDoorCount.Location = new System.Drawing.Point(674, 240);
            this.rightSideDoorCount.Margin = new System.Windows.Forms.Padding(7);
            this.rightSideDoorCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rightSideDoorCount.Name = "rightSideDoorCount";
            this.rightSideDoorCount.Size = new System.Drawing.Size(280, 28);
            this.rightSideDoorCount.TabIndex = 17;
            // 
            // leftSideDoorCount
            // 
            this.leftSideDoorCount.BackColor = System.Drawing.SystemColors.Window;
            this.leftSideDoorCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftSideDoorCount.Location = new System.Drawing.Point(670, 160);
            this.leftSideDoorCount.Margin = new System.Windows.Forms.Padding(7);
            this.leftSideDoorCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.leftSideDoorCount.Name = "leftSideDoorCount";
            this.leftSideDoorCount.Size = new System.Drawing.Size(280, 28);
            this.leftSideDoorCount.TabIndex = 16;
            // 
            // midSideDoorCountLabel
            // 
            this.midSideDoorCountLabel.AutoSize = true;
            this.midSideDoorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.midSideDoorCountLabel.Location = new System.Drawing.Point(670, 360);
            this.midSideDoorCountLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.midSideDoorCountLabel.Name = "midSideDoorCountLabel";
            this.midSideDoorCountLabel.Size = new System.Drawing.Size(162, 20);
            this.midSideDoorCountLabel.TabIndex = 15;
            this.midSideDoorCountLabel.Text = "Počet dveří na středu:";
            // 
            // rightSideDoorCountLabel
            // 
            this.rightSideDoorCountLabel.AutoSize = true;
            this.rightSideDoorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightSideDoorCountLabel.Location = new System.Drawing.Point(670, 210);
            this.rightSideDoorCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rightSideDoorCountLabel.Name = "rightSideDoorCountLabel";
            this.rightSideDoorCountLabel.Size = new System.Drawing.Size(205, 20);
            this.rightSideDoorCountLabel.TabIndex = 14;
            this.rightSideDoorCountLabel.Text = "Počet dveří na pravé straně:";
            // 
            // leftSideDoorCountLabel
            // 
            this.leftSideDoorCountLabel.AutoSize = true;
            this.leftSideDoorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideDoorCountLabel.Location = new System.Drawing.Point(670, 60);
            this.leftSideDoorCountLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.leftSideDoorCountLabel.Name = "leftSideDoorCountLabel";
            this.leftSideDoorCountLabel.Size = new System.Drawing.Size(194, 20);
            this.leftSideDoorCountLabel.TabIndex = 13;
            this.leftSideDoorCountLabel.Text = "Počet dveří na levé straně:";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(330, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(330, 503);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(330, 503);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(25, 530);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 63);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Spočítej";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.leftSideVALengthLabel);
            this.panel2.Controls.Add(this.leftSideBSLengthLabel);
            this.panel2.Controls.Add(this.leftSideHSLengthLabel);
            this.panel2.Controls.Add(this.leftSideVMLengthLabel);
            this.panel2.Controls.Add(this.leftSideVLengthLabel);
            this.panel2.Controls.Add(this.leftSideHLLengthLabel);
            this.panel2.Controls.Add(this.leftSideVACountLabel);
            this.panel2.Controls.Add(this.leftSideBSCountLabel);
            this.panel2.Controls.Add(this.leftSideHSCountLabel);
            this.panel2.Controls.Add(this.leftSideVMCountLabel);
            this.panel2.Controls.Add(this.leftSideVCountLabel);
            this.panel2.Controls.Add(this.leftSideHLCountLabel);
            this.panel2.Controls.Add(this.VALabel);
            this.panel2.Controls.Add(this.BSLabel);
            this.panel2.Controls.Add(this.HSLabel);
            this.panel2.Controls.Add(this.VMLabel);
            this.panel2.Controls.Add(this.VLabel);
            this.panel2.Controls.Add(this.leftSideHL);
            this.panel2.Controls.Add(this.splitter8);
            this.panel2.Controls.Add(this.splitter7);
            this.panel2.Controls.Add(this.splitter6);
            this.panel2.Controls.Add(this.splitter5);
            this.panel2.Controls.Add(this.splitter4);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Location = new System.Drawing.Point(1007, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 503);
            this.panel2.TabIndex = 14;
            // 
            // leftDoorCountErrorProvider
            // 
            this.leftDoorCountErrorProvider.ContainerControl = this;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(90, 503);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(90, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(90, 503);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(180, 0);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(90, 503);
            this.splitter5.TabIndex = 2;
            this.splitter5.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Location = new System.Drawing.Point(270, 0);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(90, 503);
            this.splitter6.TabIndex = 3;
            this.splitter6.TabStop = false;
            // 
            // splitter7
            // 
            this.splitter7.Location = new System.Drawing.Point(360, 0);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(90, 503);
            this.splitter7.TabIndex = 4;
            this.splitter7.TabStop = false;
            // 
            // splitter8
            // 
            this.splitter8.Location = new System.Drawing.Point(450, 0);
            this.splitter8.Name = "splitter8";
            this.splitter8.Size = new System.Drawing.Size(90, 503);
            this.splitter8.TabIndex = 5;
            this.splitter8.TabStop = false;
            // 
            // leftSideHL
            // 
            this.leftSideHL.AutoSize = true;
            this.leftSideHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideHL.Location = new System.Drawing.Point(3, 10);
            this.leftSideHL.Name = "leftSideHL";
            this.leftSideHL.Size = new System.Drawing.Size(36, 24);
            this.leftSideHL.TabIndex = 6;
            this.leftSideHL.Text = "HL";
            // 
            // VLabel
            // 
            this.VLabel.AutoSize = true;
            this.VLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VLabel.Location = new System.Drawing.Point(96, 10);
            this.VLabel.Name = "VLabel";
            this.VLabel.Size = new System.Drawing.Size(24, 24);
            this.VLabel.TabIndex = 7;
            this.VLabel.Text = "V";
            // 
            // VMLabel
            // 
            this.VMLabel.AutoSize = true;
            this.VMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VMLabel.Location = new System.Drawing.Point(186, 10);
            this.VMLabel.Name = "VMLabel";
            this.VMLabel.Size = new System.Drawing.Size(41, 24);
            this.VMLabel.TabIndex = 8;
            this.VMLabel.Text = "VM";
            // 
            // HSLabel
            // 
            this.HSLabel.AutoSize = true;
            this.HSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HSLabel.Location = new System.Drawing.Point(276, 10);
            this.HSLabel.Name = "HSLabel";
            this.HSLabel.Size = new System.Drawing.Size(38, 24);
            this.HSLabel.TabIndex = 9;
            this.HSLabel.Text = "HS";
            // 
            // BSLabel
            // 
            this.BSLabel.AutoSize = true;
            this.BSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSLabel.Location = new System.Drawing.Point(366, 10);
            this.BSLabel.Name = "BSLabel";
            this.BSLabel.Size = new System.Drawing.Size(36, 24);
            this.BSLabel.TabIndex = 10;
            this.BSLabel.Text = "BS";
            // 
            // VALabel
            // 
            this.VALabel.AutoSize = true;
            this.VALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VALabel.Location = new System.Drawing.Point(456, 10);
            this.VALabel.Name = "VALabel";
            this.VALabel.Size = new System.Drawing.Size(38, 24);
            this.VALabel.TabIndex = 11;
            this.VALabel.Text = "VA";
            // 
            // leftSideHLCountLabel
            // 
            this.leftSideHLCountLabel.AutoSize = true;
            this.leftSideHLCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideHLCountLabel.Location = new System.Drawing.Point(3, 56);
            this.leftSideHLCountLabel.Name = "leftSideHLCountLabel";
            this.leftSideHLCountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideHLCountLabel.TabIndex = 12;
            this.leftSideHLCountLabel.Text = "0 ks";
            // 
            // leftSideVCountLabel
            // 
            this.leftSideVCountLabel.AutoSize = true;
            this.leftSideVCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVCountLabel.Location = new System.Drawing.Point(96, 56);
            this.leftSideVCountLabel.Name = "leftSideVCountLabel";
            this.leftSideVCountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideVCountLabel.TabIndex = 13;
            this.leftSideVCountLabel.Text = "0 ks";
            // 
            // leftSideVMCountLabel
            // 
            this.leftSideVMCountLabel.AutoSize = true;
            this.leftSideVMCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVMCountLabel.Location = new System.Drawing.Point(186, 56);
            this.leftSideVMCountLabel.Name = "leftSideVMCountLabel";
            this.leftSideVMCountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideVMCountLabel.TabIndex = 14;
            this.leftSideVMCountLabel.Text = "0 ks";
            // 
            // leftSideHSCountLabel
            // 
            this.leftSideHSCountLabel.AutoSize = true;
            this.leftSideHSCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideHSCountLabel.Location = new System.Drawing.Point(276, 56);
            this.leftSideHSCountLabel.Name = "leftSideHSCountLabel";
            this.leftSideHSCountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideHSCountLabel.TabIndex = 15;
            this.leftSideHSCountLabel.Text = "0 ks";
            // 
            // leftSideBSCountLabel
            // 
            this.leftSideBSCountLabel.AutoSize = true;
            this.leftSideBSCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideBSCountLabel.Location = new System.Drawing.Point(366, 56);
            this.leftSideBSCountLabel.Name = "leftSideBSCountLabel";
            this.leftSideBSCountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideBSCountLabel.TabIndex = 16;
            this.leftSideBSCountLabel.Text = "0 ks";
            // 
            // leftSideVACountLabel
            // 
            this.leftSideVACountLabel.AutoSize = true;
            this.leftSideVACountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVACountLabel.Location = new System.Drawing.Point(456, 56);
            this.leftSideVACountLabel.Name = "leftSideVACountLabel";
            this.leftSideVACountLabel.Size = new System.Drawing.Size(38, 20);
            this.leftSideVACountLabel.TabIndex = 17;
            this.leftSideVACountLabel.Text = "0 ks";
            // 
            // leftSideHLLengthLabel
            // 
            this.leftSideHLLengthLabel.AutoSize = true;
            this.leftSideHLLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideHLLengthLabel.Location = new System.Drawing.Point(3, 87);
            this.leftSideHLLengthLabel.Name = "leftSideHLLengthLabel";
            this.leftSideHLLengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideHLLengthLabel.TabIndex = 18;
            this.leftSideHLLengthLabel.Text = "0 mm";
            // 
            // leftSideVLengthLabel
            // 
            this.leftSideVLengthLabel.AutoSize = true;
            this.leftSideVLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVLengthLabel.Location = new System.Drawing.Point(96, 87);
            this.leftSideVLengthLabel.Name = "leftSideVLengthLabel";
            this.leftSideVLengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideVLengthLabel.TabIndex = 19;
            this.leftSideVLengthLabel.Text = "0 mm";
            // 
            // leftSideVMLengthLabel
            // 
            this.leftSideVMLengthLabel.AutoSize = true;
            this.leftSideVMLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVMLengthLabel.Location = new System.Drawing.Point(186, 87);
            this.leftSideVMLengthLabel.Name = "leftSideVMLengthLabel";
            this.leftSideVMLengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideVMLengthLabel.TabIndex = 20;
            this.leftSideVMLengthLabel.Text = "0 mm";
            // 
            // leftSideHSLengthLabel
            // 
            this.leftSideHSLengthLabel.AutoSize = true;
            this.leftSideHSLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideHSLengthLabel.Location = new System.Drawing.Point(276, 87);
            this.leftSideHSLengthLabel.Name = "leftSideHSLengthLabel";
            this.leftSideHSLengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideHSLengthLabel.TabIndex = 21;
            this.leftSideHSLengthLabel.Text = "0 mm";
            // 
            // leftSideBSLengthLabel
            // 
            this.leftSideBSLengthLabel.AutoSize = true;
            this.leftSideBSLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideBSLengthLabel.Location = new System.Drawing.Point(366, 87);
            this.leftSideBSLengthLabel.Name = "leftSideBSLengthLabel";
            this.leftSideBSLengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideBSLengthLabel.TabIndex = 22;
            this.leftSideBSLengthLabel.Text = "0 mm";
            // 
            // leftSideVALengthLabel
            // 
            this.leftSideVALengthLabel.AutoSize = true;
            this.leftSideVALengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftSideVALengthLabel.Location = new System.Drawing.Point(456, 87);
            this.leftSideVALengthLabel.Name = "leftSideVALengthLabel";
            this.leftSideVALengthLabel.Size = new System.Drawing.Size(48, 20);
            this.leftSideVALengthLabel.TabIndex = 23;
            this.leftSideVALengthLabel.Text = "0 mm";
            // 
            // LeftSideDoorComboBox
            // 
            this.LeftSideDoorComboBox.FormattingEnabled = true;
            this.LeftSideDoorComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "4(2+2)",
            "5(3+2)",
            "6(3+3)",
            "8(4+4)"});
            this.LeftSideDoorComboBox.Location = new System.Drawing.Point(674, 90);
            this.LeftSideDoorComboBox.Name = "LeftSideDoorComboBox";
            this.LeftSideDoorComboBox.Size = new System.Drawing.Size(121, 30);
            this.LeftSideDoorComboBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Kalkulátor zimní zahrady";
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midSideDoorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftDoorCountErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown leftSideLength;
        private System.Windows.Forms.Label LeftSideLengthLabel;
        private System.Windows.Forms.Label leftSideLabel;
        private System.Windows.Forms.Label rightSideLabel;
        private System.Windows.Forms.Label RightSideLengthLabel;
        private System.Windows.Forms.NumericUpDown rightSideLength;
        private System.Windows.Forms.Label MidSideLabel;
        private System.Windows.Forms.NumericUpDown midSideLength;
        private System.Windows.Forms.Label MidSideLengthLabel;
        private System.Windows.Forms.Label LeftSideHeightLabel;
        private System.Windows.Forms.NumericUpDown midSideHeight;
        private System.Windows.Forms.NumericUpDown rightSideHeight;
        private System.Windows.Forms.NumericUpDown leftSideHeight;
        private System.Windows.Forms.Label MidSideHeightLabel;
        private System.Windows.Forms.Label RightSideHeightLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown leftSideDoorCount;
        private System.Windows.Forms.Label midSideDoorCountLabel;
        private System.Windows.Forms.Label rightSideDoorCountLabel;
        private System.Windows.Forms.Label leftSideDoorCountLabel;
        private System.Windows.Forms.NumericUpDown midSideDoorCount;
        private System.Windows.Forms.NumericUpDown rightSideDoorCount;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider leftDoorCountErrorProvider;
        private System.Windows.Forms.Label leftSideHL;
        private System.Windows.Forms.Splitter splitter8;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label VALabel;
        private System.Windows.Forms.Label BSLabel;
        private System.Windows.Forms.Label HSLabel;
        private System.Windows.Forms.Label VMLabel;
        private System.Windows.Forms.Label VLabel;
        private System.Windows.Forms.Label leftSideVACountLabel;
        private System.Windows.Forms.Label leftSideBSCountLabel;
        private System.Windows.Forms.Label leftSideHSCountLabel;
        private System.Windows.Forms.Label leftSideVMCountLabel;
        private System.Windows.Forms.Label leftSideVCountLabel;
        private System.Windows.Forms.Label leftSideHLCountLabel;
        private System.Windows.Forms.Label leftSideVALengthLabel;
        private System.Windows.Forms.Label leftSideBSLengthLabel;
        private System.Windows.Forms.Label leftSideHSLengthLabel;
        private System.Windows.Forms.Label leftSideVMLengthLabel;
        private System.Windows.Forms.Label leftSideVLengthLabel;
        private System.Windows.Forms.Label leftSideHLLengthLabel;
        private System.Windows.Forms.ComboBox LeftSideDoorComboBox;
    }
}

