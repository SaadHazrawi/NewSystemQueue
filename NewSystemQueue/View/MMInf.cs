using ExteanstionExceaption;
using NewSystemQueue.Helper;
using System;
using System.Windows.Forms;

namespace NewSystemQueue.View
{
    public partial class MMInf : Form
    {
        private double mho;
        private double lambda;
        private double p0 = -1;
        private double pN = -1;
        //TODO:Write Function to to set some field is default value
        private double rho = -1;
        private double resultPn;

        public MMInf()
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
                mho = double.Parse(txtMho.Text);
                lambda = double.Parse(txtLambda.Text);
                if (TextBoxHelper.CheckIfNegtiaveNumber(txtMho, txtLambda))
                {
                    MessageBox.Show("يوجد قيم سالبة");
                }
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
            //Calc Pn
        }
        private double CalcP0(double capacityCustomer, double rho)
        {
            var result = (1 - rho) / (1 - Math.Pow(rho, capacityCustomer + 1));
            return result;
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

        private void btnCalcP0_Click(object sender, EventArgs e)
        {
            //P0=exp^-rho
            try
            {
                if (rho == -1)
                {
                    MessageBox.Show("قم بحساب قيمة روو اولاً ثم اعد الحساب");
                    txtLambda.Focus();

                }
                else
                {
                    p0 = CalcP0(rho);
                    txtP0.Text = (p0 * 100).ToString("F2") + " %";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CalcP0(double rho)
        {
            return Math.Exp(rho * -1);
        }
    }
}
