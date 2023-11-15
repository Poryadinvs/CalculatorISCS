namespace Модуль_калькулятора
{
    public partial class TrigCalcForm : Form
    {
        public TrigCalcForm()
        {
            InitializeComponent();
            comboBoxTr.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}