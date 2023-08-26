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
            this.leftSideLength = new System.Windows.Forms.NumericUpDown();
            this.LeftSideLengthLabel = new System.Windows.Forms.Label();
            this.leftSideLabel = new System.Windows.Forms.Label();
            this.rightSideLabel = new System.Windows.Forms.Label();
            this.RightSideLengthLabel = new System.Windows.Forms.Label();
            this.rigthSideLength = new System.Windows.Forms.NumericUpDown();
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.leftSideDoorCountLabel = new System.Windows.Forms.Label();
            this.rightSideDoorCountLabel = new System.Windows.Forms.Label();
            this.midSideDoorCountLabel = new System.Windows.Forms.Label();
            this.leftSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.rightSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.midSideDoorCount = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigthSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideDoorCount)).BeginInit();
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
            // rigthSideLength
            // 
            this.rigthSideLength.BackColor = System.Drawing.SystemColors.Window;
            this.rigthSideLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rigthSideLength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rigthSideLength.Location = new System.Drawing.Point(13, 240);
            this.rigthSideLength.Margin = new System.Windows.Forms.Padding(7);
            this.rigthSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.rigthSideLength.Name = "rigthSideLength";
            this.rigthSideLength.Size = new System.Drawing.Size(280, 28);
            this.rigthSideLength.TabIndex = 7;
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
            this.panel1.Controls.Add(this.rigthSideLength);
            this.panel1.Controls.Add(this.leftSideLength);
            this.panel1.Controls.Add(this.RightSideLengthLabel);
            this.panel1.Controls.Add(this.rightSideLabel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 503);
            this.panel1.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(330, 503);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(330, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(330, 503);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
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
            // leftSideDoorCount
            // 
            this.leftSideDoorCount.BackColor = System.Drawing.SystemColors.Window;
            this.leftSideDoorCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftSideDoorCount.Location = new System.Drawing.Point(674, 87);
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
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(25, 530);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 63);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Spočítej";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 753);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Kalkulátor zimní zahrady";
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigthSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midSideDoorCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown leftSideLength;
        private System.Windows.Forms.Label LeftSideLengthLabel;
        private System.Windows.Forms.Label leftSideLabel;
        private System.Windows.Forms.Label rightSideLabel;
        private System.Windows.Forms.Label RightSideLengthLabel;
        private System.Windows.Forms.NumericUpDown rigthSideLength;
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
    }
}

