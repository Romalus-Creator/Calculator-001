using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_001
{
    public partial class Calculator01 : Form
    {
        private decimal firstNumber { get; set; }
        private decimal secondNumber { get; set; }
        private decimal totalNumber { get; set; }
        private string oper { get; set; }

        

        public Calculator01()
        {
            InitializeComponent();
        }

        //digit buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            updateText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateText("2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateText("3");

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateText("0");
        }



        //display text for the last digit button clicked
        private void updateText(string number)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = number;
            }
            else if (decimal.Parse(txtDisplay.Text) == totalNumber)
            {
                txtDisplay.Text = number;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + number;
            }
        }



        //non-digit buttons
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
            oper = "+";
            updateOper();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            oper = "-";
            updateOper();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            oper = "*";
            updateOper();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            oper = "/";
            updateOper();
        }

        //store totalNumber variable and update txtDisplay back to "0"
        private void updateOper()
        {
            firstNumber = decimal.Parse(txtDisplay.Text);
            if (totalNumber > 0)
            {
                txtDisplay.Text = totalNumber.ToString();
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }
       
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            // DONE - need to make the backspace button read the txtDisplay.Text, then subtract the far right char. good luck https://stackoverflow.com/questions/3566830/what-method-in-the-string-class-returns-only-the-first-n-characters

            if (txtDisplay.Text.Length > 1)
            {
                string substring = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtDisplay.Text = substring;
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }



        //Both buttons are a way to erase or clear an entry. The CE (clear entry) button clears the most recent entry while the C (clear) button will clear all input to the calculator.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            totalNumber = 0;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {

        }


        //resize the form
        private Rectangle originalFormSize;
        private Rectangle txtDisplay_OriginalRectangle;
        private Rectangle btn1_OriginalRectangle;
        private Rectangle btn2_OriginalRectangle;
        private Rectangle btn3_OriginalRectangle;
        private Rectangle btn4_OriginalRectangle;
        private Rectangle btn5_OriginalRectangle;
        private Rectangle btn6_OriginalRectangle;
        private Rectangle btn7_OriginalRectangle;
        private Rectangle btn8_OriginalRectangle;
        private Rectangle btn9_OriginalRectangle;
        private Rectangle btn0_OriginalRectangle;
        private Rectangle btnDecimal_OriginalRectangle;
        private Rectangle btnEquals_OriginalRectangle;
        private Rectangle btnAddition_OriginalRectangle;
        private Rectangle btnSubtraction_OriginalRectangle;
        private Rectangle btnMultiplication_OriginalRectangle;
        private Rectangle btnDivision_OriginalRectangle;
        private Rectangle btnBackspace_OriginalRectangle;
        private Rectangle btnClear_OriginalRectangle;
        private Rectangle btnClearEntry_OriginalRectangle;
        private Rectangle btnPlusOrMinus_OriginalRectangle;

        private void Calculator01_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            txtDisplay_OriginalRectangle = new Rectangle(txtDisplay.Location.X, txtDisplay.Location.Y, txtDisplay.Width, txtDisplay.Height);
            btn1_OriginalRectangle = new Rectangle(btn1.Location.X, btn1.Location.Y, btn1.Width, btn1.Height);
            btn2_OriginalRectangle = new Rectangle(btn2.Location.X, btn2.Location.Y, btn2.Width, btn2.Height);
            btn3_OriginalRectangle = new Rectangle(btn3.Location.X, btn3.Location.Y, btn3.Width, btn3.Height);
            btn4_OriginalRectangle = new Rectangle(btn4.Location.X, btn4.Location.Y, btn4.Width, btn4.Height);
            btn5_OriginalRectangle = new Rectangle(btn5.Location.X, btn5.Location.Y, btn5.Width, btn5.Height);
            btn6_OriginalRectangle = new Rectangle(btn6.Location.X, btn6.Location.Y, btn6.Width, btn6.Height);
            btn7_OriginalRectangle = new Rectangle(btn7.Location.X, btn7.Location.Y, btn7.Width, btn7.Height);
            btn8_OriginalRectangle = new Rectangle(btn8.Location.X, btn8.Location.Y, btn8.Width, btn8.Height);
            btn9_OriginalRectangle = new Rectangle(btn9.Location.X, btn9.Location.Y, btn9.Width, btn9.Height);
            btn0_OriginalRectangle = new Rectangle(btn0.Location.X, btn0.Location.Y, btn0.Width, btn0.Height);
            btnDecimal_OriginalRectangle = new Rectangle(btnDecimal.Location.X, btnDecimal.Location.Y, btnDecimal.Width, btnDecimal.Height);
            btnEquals_OriginalRectangle = new Rectangle(btnEquals.Location.X, btnEquals.Location.Y, btnEquals.Width, btnEquals.Height);
            btnAddition_OriginalRectangle = new Rectangle(btnAddition.Location.X, btnAddition.Location.Y, btnAddition.Width, btnAddition.Height);
            btnSubtraction_OriginalRectangle = new Rectangle(btnSubtraction.Location.X, btnSubtraction.Location.Y, btnSubtraction.Width, btnSubtraction.Height);
            btnMultiplication_OriginalRectangle = new Rectangle(btnMultiplication.Location.X, btnMultiplication.Location.Y, btnMultiplication.Width, btnMultiplication.Height);
            btnDivision_OriginalRectangle = new Rectangle(btnDivision.Location.X, btnDivision.Location.Y, btnDivision.Width, btnDivision.Height);
            btnBackspace_OriginalRectangle = new Rectangle(btnBackspace.Location.X, btnBackspace.Location.Y, btnBackspace.Width, btnBackspace.Height);
            btnClear_OriginalRectangle = new Rectangle(btnClear.Location.X, btnClear.Location.Y, btnClear.Width, btnClear.Height);
            btnClearEntry_OriginalRectangle = new Rectangle(btnClearEntry.Location.X, btnClearEntry.Location.Y, btnClearEntry.Width, btnClearEntry.Height);
            btnPlusOrMinus_OriginalRectangle = new Rectangle(btnPlusOrMinus.Location.X, btnPlusOrMinus.Location.Y, btnPlusOrMinus.Width, btnPlusOrMinus.Height);

        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Calculator01_Resize(object sender, EventArgs e)
        {
            resizeControl(txtDisplay_OriginalRectangle, txtDisplay);
            resizeControl(btn1_OriginalRectangle, btn1);
            resizeControl(btn2_OriginalRectangle, btn2);
            resizeControl(btn3_OriginalRectangle, btn3);
            resizeControl(btn4_OriginalRectangle, btn4);
            resizeControl(btn5_OriginalRectangle, btn5);
            resizeControl(btn6_OriginalRectangle, btn6);
            resizeControl(btn7_OriginalRectangle, btn7);
            resizeControl(btn8_OriginalRectangle, btn8);
            resizeControl(btn9_OriginalRectangle, btn9);
            resizeControl(btn0_OriginalRectangle, btn0);
            resizeControl(btnDecimal_OriginalRectangle, btnDecimal);
            resizeControl(btnEquals_OriginalRectangle, btnEquals);
            resizeControl(btnAddition_OriginalRectangle, btnAddition);
            resizeControl(btnSubtraction_OriginalRectangle, btnSubtraction);
            resizeControl(btnMultiplication_OriginalRectangle, btnMultiplication);
            resizeControl(btnDivision_OriginalRectangle, btnDivision);
            resizeControl(btnBackspace_OriginalRectangle, btnBackspace);
            resizeControl(btnClear_OriginalRectangle, btnClear);
            resizeControl(btnClearEntry_OriginalRectangle, btnClearEntry);
            resizeControl(btnPlusOrMinus_OriginalRectangle, btnPlusOrMinus);
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {

        }


    }
}
