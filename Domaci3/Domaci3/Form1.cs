namespace Domaci3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Event(Button btn)
        {
            if (resultIsOn == true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + btn.Text;
            resultIsOn = false;
        }


        int num1;
        int num2;
        string optional;
        int result;
        bool resultIsOn;

    
        private void btn1_Click(object sender, EventArgs e)
        {
            click_Event(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            click_Event(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            click_Event(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            click_Event(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            click_Event(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            click_Event(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            click_Event(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            click_Event(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            click_Event(btn9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            click_Event(btn0);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            optional = "+";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            optional = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            optional = "/";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            optional = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            optional = "sqrt";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            optional = "sqr";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            optional = "r";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if(optional == "sqrt")
            {
                result = (int)Math.Sqrt(num1);
            } 
            else if(optional == "r")
            {
                result = 1 / num1;
            }
            else
            {
                num2 = int.Parse(txtDisplay.Text);
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
                    result = (int)Math.Pow(num1, num2);
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