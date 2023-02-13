using System.Reflection.Emit;

namespace Domaci3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Event_Number(Button btn)
        {
            if (resultIsOn == true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + btn.Text;
            resultIsOn = false;
        }

        private void click_Event_Operand(String operand)
        {
            optional = operand;
            num1 = float.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }


        float num1;
        float num2;
        float result;
        string optional;
        bool resultIsOn;

    
        private void btn1_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            click_Event_Number(btn0);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            click_Event_Number(btnDot);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            click_Event_Operand("+");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            click_Event_Operand("-");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            click_Event_Operand("/");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            click_Event_Operand("*");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            click_Event_Operand("sqrt");
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            click_Event_Operand("sqr");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            click_Event_Operand("r");
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (optional == "sqrt")
            {
                result = (float)Math.Sqrt(num1);
            }
            else if (optional == "r")
            {
                result = 1 / num1;
            }
            else
            {
                num2 = float.Parse(txtDisplay.Text);
            }

            switch (optional)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "sqr":
                    result = (float)Math.Pow(num1, num2);
                    break;
                default:
                    txtDisplay.Text = "Niste dobro uneli vrednosti";
                    break;

            }

            resultIsOn = true;
            txtDisplay.Text = (result.ToString());
        }

      
    }
}