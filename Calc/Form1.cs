using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         Имя ComboBox - CalcMethod_Select
         Имя TextBox первого значения - FirstTextBox
         Имя TextBox второго значения - SecondTextBox
         Имя TextBox результата - ResultTextBox
         Имя Button вычесления - ResultButton

         В Designer.cs
         {
         this.CalcMethod_Select.SelectedIndex = 0;
         }
        */
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
    }
}
