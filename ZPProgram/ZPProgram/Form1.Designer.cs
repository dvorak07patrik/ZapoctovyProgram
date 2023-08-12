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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftSideHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.leftSideLength.Location = new System.Drawing.Point(10, 70);
            this.leftSideLength.Margin = new System.Windows.Forms.Padding(4);
            this.leftSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.leftSideLength.Name = "leftSideLength";
            this.leftSideLength.Size = new System.Drawing.Size(160, 22);
            this.leftSideLength.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Délka levé strany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Levá strana";
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
            this.leftSideHeight.Location = new System.Drawing.Point(22, 102);
            this.leftSideHeight.Margin = new System.Windows.Forms.Padding(4);
            this.leftSideHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.leftSideHeight.Name = "leftSideHeight";
            this.leftSideHeight.Size = new System.Drawing.Size(81, 22);
            this.leftSideHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Výška levé strany:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pravá strana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Délka pravé strany:";
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
            this.rigthSideLength.Location = new System.Drawing.Point(10, 170);
            this.rigthSideLength.Margin = new System.Windows.Forms.Padding(4);
            this.rigthSideLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.rigthSideLength.Name = "rigthSideLength";
            this.rigthSideLength.Size = new System.Drawing.Size(160, 22);
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
            this.rightSideHeight.Location = new System.Drawing.Point(22, 207);
            this.rightSideHeight.Margin = new System.Windows.Forms.Padding(4);
            this.rightSideHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.rightSideHeight.Name = "rightSideHeight";
            this.rightSideHeight.Size = new System.Drawing.Size(81, 22);
            this.rightSideHeight.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Výška pravé strany:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.leftSideLength);
            this.splitContainer1.Panel1.Controls.Add(this.rigthSideLength);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(438, 569);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 593);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rightSideHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leftSideHeight);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown leftSideHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rigthSideLength;
        private System.Windows.Forms.NumericUpDown rightSideHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

