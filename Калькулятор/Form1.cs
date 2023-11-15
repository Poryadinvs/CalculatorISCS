namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxInfo.Multiline = true;
            textBoxInfo.ScrollBars = ScrollBars.Both;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }


        private void CalculateHex()
        {
            int decimalNumber; if (int.TryParse(textBoxP.Text, out decimalNumber))
            {
                string hexNumber = decimalNumber.ToString("X");
                textBoxP.Text = hexNumber;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxP.Clear();
            }
        }
        private void CalculateBinary()
        {
            string Enter_data = textBoxP.Text;
            int data;
            string binary = "";
            if (Int32.TryParse(Enter_data, out data))
            {
                while (data > 0)
                {
                    int reminder = data % 2;
                    binary = reminder + binary;
                    data = data / 2;
                }
                textBoxP.Text = binary;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxP.Clear();
            }
        }
        public void CalculateOcto()
        {
            string Data = textBoxP.Text;
            int num;
            if (Int32.TryParse(textBoxP.Text, out num))
            {
                string eight = "";
                string r_eight = "";
                while (num > 0)
                {

                    eight += (num % 8).ToString();
                    num = num / 8;
                }
                for (int i = eight.Length - 1; i >= 0; i--)
                {
                    r_eight += eight[i];
                }

                textBoxP.Text = r_eight;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxP.Clear();
            }



        }

        private void ProgB_Click_1(object sender, EventArgs e)
        {
            switch (comboBoxP.SelectedIndex)
            {
                case 0:
                    {
                        CalculateBinary();

                        break;
                    }
                case 1:
                    {
                        CalculateHex();
                        break;
                    }
                case 2:
                    {
                        CalculateOcto();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Skill Issue", "Huge Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        public enum TrigFuncType
        {
            Sin,
            Cos,
            Tan,
            Ctg,
            Asin,
            Acos,
            Atan,
            Actg,
        }

        public static double Calc(double value, TrigFuncType type)
        {
            switch (type)
            {
                case TrigFuncType.Sin: return Math.Sin(value);

                case TrigFuncType.Cos: return Math.Cos(value);

                case TrigFuncType.Tan: return Math.Tan(value);

                case TrigFuncType.Ctg: return (1 / Math.Tan(value));

                case TrigFuncType.Acos: return Math.Acos(value);

                case TrigFuncType.Atan: return Math.Atan(value);

                case TrigFuncType.Actg: return Math.Atan(1 / value);

                default: return value;
            }
        }


        private void buttonTr_Click(object sender, EventArgs e)
        {
            switch (comboBoxTr.SelectedItem)
            {
                case "Sin":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Sin).ToString();
                    break;

                case "Cos":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Cos).ToString();
                    break;

                case "Tan":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Tan).ToString();
                    break;

                case "Ctg":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Ctg).ToString();
                    break;
                case "Asin":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Asin).ToString();
                    break;

                case "Acos":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Acos).ToString();
                    break;

                case "Atan":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Atan).ToString();
                    break;

                case "Actg":
                    textBoxTr2.Text = Calc(double.Parse(textBoxTr.Text), TrigFuncType.Actg).ToString();
                    break;

                default:
                    break;
            }
        }



        private double CalculateFactorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }

        private void CalcMethod_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CalcMethod_Select.SelectedItem == "√" || CalcMethod_Select.SelectedItem == "!")
            {
                SecondTextBox.ReadOnly = true;
            }
            else { SecondTextBox.ReadOnly = false; }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;

            double.TryParse(FirstTextBox.Text, out x);
            double.TryParse(SecondTextBox.Text, out y);

            switch (CalcMethod_Select.SelectedItem)
            {
                case "+":
                    {
                        double result = 0;
                        result = x + y;

                        ResultTextBox.Text = result.ToString();
                    }
                    break;
                case "-":
                    {
                        double result = 0;
                        result = x - y;

                        ResultTextBox.Text = result.ToString();
                    }
                    break;
                case "/":
                    {
                        double result = 0;
                        result = x / y;

                        ResultTextBox.Text = result.ToString();

                        if (y == 0) ResultTextBox.Text = "Деление на 0 невозможно";
                    }
                    break;
                case "*":
                    {
                        double result = 0;
                        result = x * y;

                        ResultTextBox.Text = result.ToString();
                    }
                    break;
                case "√":
                    {
                        double squareRoot = Math.Sqrt(x); ResultTextBox.Text = squareRoot.ToString();
                    }
                    break;
                case "^":
                    {
                        double result = Math.Pow(x, y);
                        ResultTextBox.Text = result.ToString();
                    }
                    break;
                case "!":
                    {
                        double factorial = CalculateFactorial(x);
                        ResultTextBox.Text = factorial.ToString();
                    }
                    break;
                default: break;
            }
        }
    }
}