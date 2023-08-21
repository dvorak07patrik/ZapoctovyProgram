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
            this.leftSideHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rightSideLabel = new System.Windows.Forms.Label();
            this.RightSideLengthLabel = new System.Windows.Forms.Label();
            this.rigthSideLength = new System.Windows.Forms.NumericUpDown();
            this.rightSideHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigthSideLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.leftSideLength.Location = new System.Drawing.Point(17, 86);
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
            this.LeftSideLengthLabel.Location = new System.Drawing.Point(12, 54);
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
            this.leftSideLabel.Location = new System.Drawing.Point(10, 0);
            this.leftSideLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.leftSideLabel.Name = "leftSideLabel";
            this.leftSideLabel.Size = new System.Drawing.Size(119, 33);
            this.leftSideLabel.TabIndex = 2;
            this.leftSideLabel.Text = "Levá strana";
            // 
            // leftSideHeight
            // 
            this.leftSideHeight.BackColor = System.Drawing.SystemColors.Window;
            this.leftSideHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.leftSideHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.leftSideHeight.Location = new System.Drawing.Point(38, 185);
            this.leftSideHeight.Margin = new System.Windows.Forms.Padding(7);
            this.leftSideHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.leftSideHeight.Name = "leftSideHeight";
            this.leftSideHeight.Size = new System.Drawing.Size(142, 28);
            this.leftSideHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Výška levé strany:";
            // 
            // rightSideLabel
            // 
            this.rightSideLabel.AutoSize = true;
            this.rightSideLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightSideLabel.Location = new System.Drawing.Point(11, 151);
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
            this.RightSideLengthLabel.Location = new System.Drawing.Point(12, 198);
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
            this.rigthSideLength.Location = new System.Drawing.Point(16, 225);
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
            // rightSideHeight
            // 
            this.rightSideHeight.BackColor = System.Drawing.SystemColors.Window;
            this.rightSideHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rightSideHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rightSideHeight.Location = new System.Drawing.Point(38, 375);
            this.rightSideHeight.Margin = new System.Windows.Forms.Padding(7);
            this.rightSideHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.rightSideHeight.Name = "rightSideHeight";
            this.rightSideHeight.Size = new System.Drawing.Size(142, 28);
            this.rightSideHeight.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Výška pravé strany:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(21, 22);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftSideLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LeftSideLengthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.leftSideLength);
            this.splitContainer1.Panel1.Controls.Add(this.rigthSideLength);
            this.splitContainer1.Panel1.Controls.Add(this.rightSideLabel);
            this.splitContainer1.Panel1.Controls.Add(this.RightSideLengthLabel);
            this.splitContainer1.Size = new System.Drawing.Size(766, 704);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rightSideHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leftSideHeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Kalkulátor zimní zahrady";
            ((System.ComponentModel.ISupportInitialize)(this.leftSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rigthSideLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideHeight)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown leftSideLength;
        private System.Windows.Forms.Label LeftSideLengthLabel;
        private System.Windows.Forms.Label leftSideLabel;
        private System.Windows.Forms.NumericUpDown leftSideHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rightSideLabel;
        private System.Windows.Forms.Label RightSideLengthLabel;
        private System.Windows.Forms.NumericUpDown rigthSideLength;
        private System.Windows.Forms.NumericUpDown rightSideHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

