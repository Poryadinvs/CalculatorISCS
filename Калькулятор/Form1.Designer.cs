namespace Калькулятор
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ResultButton = new Button();
            CalcMethod_Select = new ComboBox();
            ResultTextBox = new TextBox();
            SecondTextBox = new TextBox();
            FirstTextBox = new TextBox();
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxTr2 = new TextBox();
            comboBoxTr = new ComboBox();
            buttonTr = new Button();
            textBoxTr = new TextBox();
            tabPage3 = new TabPage();
            comboBoxP = new ComboBox();
            ProgB = new Button();
            textBoxP = new TextBox();
            tabPage4 = new TabPage();
            textBoxInfo = new TextBox();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(990, 341);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ResultButton);
            tabPage1.Controls.Add(CalcMethod_Select);
            tabPage1.Controls.Add(ResultTextBox);
            tabPage1.Controls.Add(SecondTextBox);
            tabPage1.Controls.Add(FirstTextBox);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(982, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Калькулятор";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(38, 83);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(150, 71);
            ResultButton.TabIndex = 4;
            ResultButton.Text = "Посчитать";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // CalcMethod_Select
            // 
            CalcMethod_Select.FormattingEnabled = true;
            CalcMethod_Select.Items.AddRange(new object[] { "+", "-", "/", "*", "√", "^", "!" });
            CalcMethod_Select.Location = new Point(196, 29);
            CalcMethod_Select.Name = "CalcMethod_Select";
            CalcMethod_Select.Size = new Size(182, 33);
            CalcMethod_Select.TabIndex = 3;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(570, 31);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(150, 31);
            ResultTextBox.TabIndex = 2;
            // 
            // SecondTextBox
            // 
            SecondTextBox.Location = new Point(402, 31);
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size(150, 31);
            SecondTextBox.TabIndex = 1;
            // 
            // FirstTextBox
            // 
            FirstTextBox.Location = new Point(38, 29);
            FirstTextBox.Name = "FirstTextBox";
            FirstTextBox.Size = new Size(150, 31);
            FirstTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBoxTr2);
            tabPage2.Controls.Add(comboBoxTr);
            tabPage2.Controls.Add(buttonTr);
            tabPage2.Controls.Add(textBoxTr);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(982, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Тригонометрия";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 13;
            label3.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 12;
            label2.Text = "Mode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 11;
            label4.Text = "Value";
            // 
            // textBoxTr2
            // 
            textBoxTr2.Location = new Point(120, 150);
            textBoxTr2.Margin = new Padding(4);
            textBoxTr2.Name = "textBoxTr2";
            textBoxTr2.Size = new Size(529, 31);
            textBoxTr2.TabIndex = 10;
            // 
            // comboBoxTr
            // 
            comboBoxTr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTr.FormattingEnabled = true;
            comboBoxTr.Items.AddRange(new object[] { "Sin", "Cos", "Tan", "Ctg", "Asin", "Acos", "Atan", "Actg" });
            comboBoxTr.Location = new Point(120, 40);
            comboBoxTr.Margin = new Padding(4);
            comboBoxTr.Name = "comboBoxTr";
            comboBoxTr.Size = new Size(188, 33);
            comboBoxTr.TabIndex = 9;
            // 
            // buttonTr
            // 
            buttonTr.Location = new Point(40, 100);
            buttonTr.Margin = new Padding(4);
            buttonTr.Name = "buttonTr";
            buttonTr.Size = new Size(118, 36);
            buttonTr.TabIndex = 8;
            buttonTr.Text = "Calculate";
            buttonTr.UseVisualStyleBackColor = true;
            buttonTr.Click += buttonTr_Click;
            // 
            // textBoxTr
            // 
            textBoxTr.Location = new Point(450, 40);
            textBoxTr.Margin = new Padding(4);
            textBoxTr.Name = "textBoxTr";
            textBoxTr.Size = new Size(155, 31);
            textBoxTr.TabIndex = 7;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBoxP);
            tabPage3.Controls.Add(ProgB);
            tabPage3.Controls.Add(textBoxP);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(982, 303);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Программист";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxP
            // 
            comboBoxP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxP.FormattingEnabled = true;
            comboBoxP.Items.AddRange(new object[] { "Binary", "Heximal", "Octal" });
            comboBoxP.Location = new Point(281, 30);
            comboBoxP.Margin = new Padding(4, 5, 4, 5);
            comboBoxP.Name = "comboBoxP";
            comboBoxP.Size = new Size(171, 33);
            comboBoxP.TabIndex = 5;
            // 
            // ProgB
            // 
            ProgB.Location = new Point(497, 28);
            ProgB.Margin = new Padding(4, 5, 4, 5);
            ProgB.Name = "ProgB";
            ProgB.Size = new Size(232, 185);
            ProgB.TabIndex = 4;
            ProgB.Text = "Посчитать";
            ProgB.UseVisualStyleBackColor = true;
            ProgB.Click += ProgB_Click_1;
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(25, 28);
            textBoxP.Margin = new Padding(4, 5, 4, 5);
            textBoxP.Multiline = true;
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(232, 185);
            textBoxP.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBoxInfo);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(982, 303);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "О разработке";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(17, 18);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(959, 269);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 370);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox comboBoxP;
        private Button ProgB;
        private TextBox textBoxP;
        private TabPage tabPage4;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBoxTr2;
        private ComboBox comboBoxTr;
        private Button buttonTr;
        private TextBox textBoxTr;
        private TextBox textBoxInfo;
        private Button ResultButton;
        private ComboBox CalcMethod_Select;
        private TextBox ResultTextBox;
        private TextBox SecondTextBox;
        private TextBox FirstTextBox;
        private BindingSource bindingSource1;
    }
}