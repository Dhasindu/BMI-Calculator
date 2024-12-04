namespace BMIcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Weighttxt = new System.Windows.Forms.TextBox();
            this.heighttxt = new System.Windows.Forms.TextBox();
            this.bmiCalcbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.displayBmi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 102);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 55);
            this.label4.TabIndex = 2;
            this.label4.Text = "Weight :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 55);
            this.label5.TabIndex = 3;
            this.label5.Text = "Height :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weighttxt
            // 
            this.Weighttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weighttxt.Location = new System.Drawing.Point(204, 137);
            this.Weighttxt.Multiline = true;
            this.Weighttxt.Name = "Weighttxt";
            this.Weighttxt.Size = new System.Drawing.Size(160, 56);
            this.Weighttxt.TabIndex = 4;
            this.Weighttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heighttxt
            // 
            this.heighttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heighttxt.Location = new System.Drawing.Point(509, 136);
            this.heighttxt.Multiline = true;
            this.heighttxt.Name = "heighttxt";
            this.heighttxt.Size = new System.Drawing.Size(160, 56);
            this.heighttxt.TabIndex = 5;
            this.heighttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmiCalcbtn
            // 
            this.bmiCalcbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiCalcbtn.Location = new System.Drawing.Point(183, 260);
            this.bmiCalcbtn.Name = "bmiCalcbtn";
            this.bmiCalcbtn.Size = new System.Drawing.Size(191, 56);
            this.bmiCalcbtn.TabIndex = 6;
            this.bmiCalcbtn.Text = "Calculate";
            this.bmiCalcbtn.UseVisualStyleBackColor = true;
            this.bmiCalcbtn.Click += new System.EventHandler(this.bmiCalcbtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(483, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 55);
            this.label6.TabIndex = 8;
            this.label6.Text = "Health Status :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayBmi
            // 
            this.displayBmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayBmi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBmi.Location = new System.Drawing.Point(332, 402);
            this.displayBmi.Name = "displayBmi";
            this.displayBmi.Size = new System.Drawing.Size(203, 55);
            this.displayBmi.TabIndex = 9;
            this.displayBmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(729, 500);
            this.Controls.Add(this.displayBmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bmiCalcbtn);
            this.Controls.Add(this.heighttxt);
            this.Controls.Add(this.Weighttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(747, 547);
            this.MinimumSize = new System.Drawing.Size(747, 547);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Weighttxt;
        private System.Windows.Forms.TextBox heighttxt;
        private System.Windows.Forms.Button bmiCalcbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displayBmi;
    }
}

