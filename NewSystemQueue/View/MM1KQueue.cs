using ExteanstionExceaption;
using NewSystemQueue.Helper;
using System;
using System.Windows.Forms;

namespace NewSystemQueue.View
{
    public partial class MM1KQueue : Form
    {
        private double mho;
        private double lambda;
        private double capacityCustomer;
        private double p0;
        //TODO:Write Function to to set some field is default value
        private double rho = -1;
        private double resultPn;

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
                if (mho <= 0)
                {
                    txtMho.Text = string.Empty;
                    txtMho.Focus();
                    throw new DivideByZeroException("can not mho equla zero or negative number fix him");
                }
                if (lambda >= mho)
                {
                    txtMho.Text = string.Empty;
                    txtLambda.Text = string.Empty;
                    txtLambda.Focus();
                    throw new SystemUnstableException("لا يمكن أن تكون لامدا أكبر او تساوي ميو");
                }
                rho = CalcRho(lambda, mho);
                txtRho.Text = (rho * 100).ToString("F2") + " %";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private double CalcRho(double lambda, double mho)
        {
            return lambda / mho;
        }

        private void btnCalcPn_Click(object sender, EventArgs e)
        {
            //TODO:For Student Check if throw any Exception 
            var p0Result = p0 * Math.Pow(rho, Convert.ToInt32(txtN.Text));
            resultPn = p0Result * 100;
            txtPn.Text = resultPn.ToString();
        }

        private void btnCalcP0_Click(object sender, EventArgs e)
        {
            //TODO:Check if k is negative number 
            capacityCustomer = Convert.ToDouble(txtK.Text);
            p0 = CalcP0(capacityCustomer, rho);
            txtP0.Text = (p0 * 100).ToString("F2") + " %";
        }

        private double CalcP0(double capacityCustomer, double rho)
        {
            var result = (1 - rho) / (1 - Math.Pow(rho, capacityCustomer + 1));
            return result;
        }

        private void btnCalcPk_Click(object sender, EventArgs e)
        {
            //TODO:For Student Check if throw any Exception 
            var result = p0 * Math.Pow(rho, Convert.ToInt32(txtK.Text));
            txtPk.Text = (result * 100).ToString("F2") + " %";
        }

        private void btnCalcLs_Click(object sender, EventArgs e)
        {
            capacityCustomer = Convert.ToDouble(txtK.Text);
            var result = btnCalcLsResult(capacityCustomer);
            txtLS.Text = (result ).ToString("F0");
        }

        private double btnCalcLsResult(double capacityCustomer)
        {
            double sum = 0;
            for (int i = 1; i <= capacityCustomer; i++)
            {
                sum += (i * resultPn);
            }
            return sum;
        }
    }
}
