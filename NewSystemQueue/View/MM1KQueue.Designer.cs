﻿
namespace NewSystemQueue.View
{
    partial class MM1KQueue
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
            this.lblMMSReultP0 = new System.Windows.Forms.Label();
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtMho = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.btnCalcP0 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.btnCalcRho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalcPn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMMSReultP0
            // 
            this.lblMMSReultP0.AutoSize = true;
            this.lblMMSReultP0.Location = new System.Drawing.Point(602, 289);
            this.lblMMSReultP0.Name = "lblMMSReultP0";
            this.lblMMSReultP0.Size = new System.Drawing.Size(25, 17);
            this.lblMMSReultP0.TabIndex = 35;
            this.lblMMSReultP0.Text = "P0";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(422, 281);
            this.txtP0.Name = "txtP0";
            this.txtP0.Size = new System.Drawing.Size(144, 22);
            this.txtP0.TabIndex = 31;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(346, 226);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(220, 22);
            this.txtK.TabIndex = 32;
            // 
            // txtMho
            // 
            this.txtMho.Location = new System.Drawing.Point(346, 129);
            this.txtMho.Name = "txtMho";
            this.txtMho.Size = new System.Drawing.Size(220, 22);
            this.txtMho.TabIndex = 29;
            // 
            // txtLambda
            // 
            this.txtLambda.BackColor = System.Drawing.Color.White;
            this.txtLambda.Location = new System.Drawing.Point(346, 80);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(220, 22);
            this.txtLambda.TabIndex = 27;
            // 
            // btnCalcP0
            // 
            this.btnCalcP0.Location = new System.Drawing.Point(345, 278);
            this.btnCalcP0.Name = "btnCalcP0";
            this.btnCalcP0.Size = new System.Drawing.Size(71, 28);
            this.btnCalcP0.TabIndex = 34;
            this.btnCalcP0.Text = "Calc P";
            this.btnCalcP0.UseVisualStyleBackColor = true;
            this.btnCalcP0.Click += new System.EventHandler(this.btnCalcP0_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "K is Capacity of Customers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(602, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "mho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "lambda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Rho";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(422, 180);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(144, 22);
            this.txtRho.TabIndex = 36;
            // 
            // btnCalcRho
            // 
            this.btnCalcRho.Location = new System.Drawing.Point(346, 177);
            this.btnCalcRho.Name = "btnCalcRho";
            this.btnCalcRho.Size = new System.Drawing.Size(70, 28);
            this.btnCalcRho.TabIndex = 37;
            this.btnCalcRho.Text = "Calc P";
            this.btnCalcRho.UseVisualStyleBackColor = true;
            this.btnCalcRho.Click += new System.EventHandler(this.btnCalcRho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "N is Count Of Customer in Queue System But n<=k";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 39;
            // 
            // btnCalcPn
            // 
            this.btnCalcPn.Location = new System.Drawing.Point(345, 390);
            this.btnCalcPn.Name = "btnCalcPn";
            this.btnCalcPn.Size = new System.Drawing.Size(71, 28);
            this.btnCalcPn.TabIndex = 40;
            this.btnCalcPn.Text = "Calc Pn";
            this.btnCalcPn.UseVisualStyleBackColor = true;
            this.btnCalcPn.Click += new System.EventHandler(this.btnCalcPn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pn";
            // 
            // txtPn
            // 
            this.txtPn.Location = new System.Drawing.Point(422, 393);
            this.txtPn.Name = "txtPn";
            this.txtPn.Size = new System.Drawing.Size(144, 22);
            this.txtPn.TabIndex = 42;
            // 
            // MM1KQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalcPn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRho);
            this.Controls.Add(this.btnCalcRho);
            this.Controls.Add(this.lblMMSReultP0);
            this.Controls.Add(this.txtP0);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtMho);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.btnCalcP0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "MM1KQueue";
            this.Text = "MM1KQueue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMMSReultP0;
        private System.Windows.Forms.TextBox txtP0;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtMho;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Button btnCalcP0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.Button btnCalcRho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalcPn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPn;
    }
}