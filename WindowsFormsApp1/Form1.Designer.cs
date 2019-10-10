namespace WindowsFormsApp1
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
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a_val = new System.Windows.Forms.TextBox();
            this.b_val = new System.Windows.Forms.TextBox();
            this.c_val = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.final_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(23, 107);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Solve";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear.Location = new System.Drawing.Point(23, 136);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // a_val
            // 
            this.a_val.Location = new System.Drawing.Point(26, 56);
            this.a_val.Name = "a_val";
            this.a_val.Size = new System.Drawing.Size(87, 20);
            this.a_val.TabIndex = 2;
            this.a_val.Text = "0";
            this.a_val.TextChanged += new System.EventHandler(this.a_val_TextChanged);
            // 
            // b_val
            // 
            this.b_val.Location = new System.Drawing.Point(148, 56);
            this.b_val.Name = "b_val";
            this.b_val.Size = new System.Drawing.Size(89, 20);
            this.b_val.TabIndex = 3;
            this.b_val.Text = "0";
            this.b_val.TextChanged += new System.EventHandler(this.b_val_TextChanged);
            // 
            // c_val
            // 
            this.c_val.Location = new System.Drawing.Point(272, 56);
            this.c_val.Name = "c_val";
            this.c_val.Size = new System.Drawing.Size(78, 20);
            this.c_val.TabIndex = 4;
            this.c_val.Text = "0";
            this.c_val.TextChanged += new System.EventHandler(this.c_val_TextChanged);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(128, 59);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 13);
            this.B.TabIndex = 5;
            this.B.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.c_val);
            this.groupBox1.Controls.Add(this.b_val);
            this.groupBox1.Controls.Add(this.a_val);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Coefficients:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Final Result";
            // 
            // final_result
            // 
            this.final_result.Enabled = false;
            this.final_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_result.Location = new System.Drawing.Point(142, 135);
            this.final_result.Name = "final_result";
            this.final_result.Size = new System.Drawing.Size(208, 22);
            this.final_result.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ax2+Bx+C";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 169);
            this.Controls.Add(this.final_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Quadratic Solver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a_val;
        private System.Windows.Forms.TextBox b_val;
        private System.Windows.Forms.TextBox c_val;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox final_result;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Label label4;
    }
}

