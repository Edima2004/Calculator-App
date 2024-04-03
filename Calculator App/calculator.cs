namespace Calculator_App
{
    public partial class calculator : Form
    {
        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        private double testValue = 0;
        private decimal result = 0.0m;
        private string operators = "+";


        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "x";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void percentageBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";

            String f, s;
            f = Convert.ToString(firstValue);
            s = Convert.ToString(firstValue);

            f = "";
            s = "";

        }

        private void button33_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }



        private void delBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Length > 0)
            {
                TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1, 1);
            }
            if (TxtBox.Text == "")
                {
                TxtBox.Text = "0";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Text += "^2";
            operators = "square";
        }
        private void cubeBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Text += "^3";
            operators = "cube";
        }
        private void button27_Click(object sender, EventArgs e)
        {
            testValue = double.Parse(TxtBox.Text);
            operators = "sqrt";

            switch (operators)
            {
                case "sqrt":
                    result = (decimal)Math.Sqrt(testValue);
                    TxtBox.Text = result.ToString();
                    break;
            }

        }
        private void button36_Click(object sender, EventArgs e)
        {
            testValue = double.Parse(TxtBox.Text);
            operators = "cbrt";

            switch (operators)
            {
                case "cbrt":
                    result = (decimal)Math.Cbrt(testValue);
                    TxtBox.Text = result.ToString();
                    break;
            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            testValue = double.Parse(TxtBox.Text);
            TxtBox.Text += "^-1";
            operators = "inverse";
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "sin ";
            operators = "sin";
            TxtBox.Clear();

        }
        private void cosBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "cos ";
            operators = "cos";
            TxtBox.Clear();
        }
        private void tanBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "tan ";
            operators = "tan";
            TxtBox.Clear();
        }
        private void lnBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "ln ";
            operators = "ln";
            TxtBox.Clear();
        }
        private void logBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "log10 ";
            operators = "log";
            TxtBox.Clear();
        }
        private void powerBtn_Click(object sender, EventArgs e)
        {
            testValue = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "^";
        }
        private void piBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = Math.PI.ToString();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "exp";
        }
        private void opBracketBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(a, 2);
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(TxtBox.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            TxtBox.Text = Convert.ToString(i2);
        }
        private void hexBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(a, 16);
        }
        private void octBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox.Text = Convert.ToString(a, 8);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            testValue = double.Parse(TxtBox.Text);
            operators = "percentage";

            switch (operators)
            {
                case "percentage":
                    result = (decimal)testValue / 100;
                    TxtBox.Text = result.ToString();
                    break;
            }
        }

        private void factorialBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Text += "!";
            int newNum = 1;
            for (int i = 1; i <= firstValue; i++)
            {
                newNum *= i;
            }
            TxtBox.Text = newNum.ToString();
        }
        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = secondValue + firstValue;
                    TxtBox.Text = result.ToString();
                    break;

                case "-":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue - secondValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "x":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = secondValue * firstValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "/":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue - secondValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "%":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue % secondValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "square":
                    result = firstValue * firstValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "cube":
                    result = firstValue * firstValue * firstValue;
                    TxtBox.Text = result.ToString();
                    break;
                case "inverse":
                    result = (decimal)Math.Pow(testValue, -1);
                    TxtBox.Text = result.ToString();
                    break;
                case "exp":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Exp(testValue);
                    TxtBox.Text = result.ToString();
                    break;
                case "sin":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Sin(testValue * (Math.PI / 180));
                    TxtBox.Text = result.ToString();
                    break;
                case "cos":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Cos(testValue * (Math.PI / 180));
                    TxtBox.Text = result.ToString();
                    break;
                case "tan":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Tan(testValue * (Math.PI / 180));
                    TxtBox.Text = result.ToString();
                    break;
                case "log":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Log10(testValue);
                    TxtBox.Text = result.ToString();
                    break;
                case "ln":
                    testValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Log(testValue);
                    TxtBox.Text = result.ToString();
                    break;
                case "^":
                    double nextValue = double.Parse(TxtBox.Text);
                    result = (decimal)Math.Pow(testValue, nextValue);
                    TxtBox.Text = result.ToString();
                    break;
            }
        }

        
    }
}
