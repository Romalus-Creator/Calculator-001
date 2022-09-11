using System.Configuration;
using System.Text.RegularExpressions;

namespace Calculator_001
{
    public partial class Form1 : Form
    {
        decimal firstNumber;
        decimal secondNumber;
        decimal totalNumber;
        string oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
                {
                txtDisplay.Text = txtDisplay.Text + "";
            }
            else if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0.";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = decimal.Parse(txtDisplay.Text);
            switch (oper)
            {
                case "+":
                    {
                        totalNumber = firstNumber + secondNumber;
                        break;
                    }
                case "-":
                    {
                        totalNumber = firstNumber - secondNumber;
                        break;
                    }
                case "*":
                    {
                        totalNumber = firstNumber * secondNumber;
                        break;
                    }
                case "/":
                    {
                        totalNumber = firstNumber / secondNumber;
                        break;
                    }
                default:
                    txtDisplay.Text = "";
                    break;

            }
            txtDisplay.Text = totalNumber.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "0";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            // need to make the backspace button read the txtDisplay.Text, then subtract the far right char. good luck https://stackoverflow.com/questions/3566830/what-method-in-the-string-class-returns-only-the-first-n-characters
            strings.Left(txtDisplay.Text, txtDisplay.Text.Length);
        }

        /*Both buttons are a way to erase or clear an entry. 
         * The CE (clear entry) button clears the most recent entry 
         * while the C (clear) button will clear all input to the calculator. */

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            secondNumber = 0;
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {

        }
    }
}