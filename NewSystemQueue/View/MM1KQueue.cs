﻿using ExteanstionExceaption;
using NewSystemQueue.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSystemQueue.View
{
    public partial class MM1KQueue : Form
    {
        private double mho;
        private double lambda;
        //TODO:Write Function to to set some field is default value
        private double rho=-1;
        public MM1KQueue()
        {
            InitializeComponent();
            ApplayAcceptOnlyNumberInTextBox();
        }
        private void ApplayAcceptOnlyNumberInTextBox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyPress += InputHelper.HandleNumericInput;
                }
            }
        }

        private void btnCalcRho_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO:Write Function to check if number is negative
                mho = double.Parse(txtMho.Text);
                lambda = double.Parse(txtLambda.Text);
                if(mho<=0)
                {
                    txtMho.Text = string.Empty;
                    txtMho.Focus();
                    throw new DivideByZeroException("can not mho equla zero or negative number fix him");
                }
                if(lambda>=mho)
                {
                    txtMho.Text = string.Empty;
                    txtLambda.Text = string.Empty;
                    txtLambda.Focus();
                    throw new SystemUnstableException("لا يمكن أن تكون لامدا أكبر او تساوي ميو");
                }
                rho = CaclRho(mho, lambda);
                txtRho.Text = (rho * 100).ToString("F2") + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CaclRho(double mho, double lambda)
        {
            return lambda / mho;
        }

        private void btnCalcPn_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcP0_Click(object sender, EventArgs e)
        {

        }
    }
}