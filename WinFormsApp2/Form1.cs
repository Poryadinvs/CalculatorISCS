namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
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

        private void CalculateHex()
        {
            int decimalNumber; if (int.TryParse(textBox1.Text, out decimalNumber))
            {
                string hexNumber = decimalNumber.ToString("X");
                textBox1.Text = hexNumber;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
        private void CalculateBinary()
        {
            string Enter_data = textBox1.Text;
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
                textBox1.Text = binary;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
        public void CalculateOcto()
        {
            string Data = textBox1.Text;
            int num;
            if (Int32.TryParse(textBox1.Text, out num))
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

                textBox1.Text = r_eight;
            }
            else
            {
                MessageBox.Show("Введите корректное десятичное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            
            
            
        }

    }
}