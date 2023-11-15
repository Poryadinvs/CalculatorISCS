namespace Модуль_калькулятора
{
    partial class TrigCalcForm
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
            textBoxTr = new TextBox();
            buttonTr = new Button();
            comboBoxTr = new ComboBox();
            textBoxTr2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxTr
            // 
            textBoxTr.Location = new Point(490, 40);
            textBoxTr.Margin = new Padding(4, 4, 4, 4);
            textBoxTr.Name = "textBoxTr";
            textBoxTr.Size = new Size(155, 31);
            textBoxTr.TabIndex = 0;
            // 
            // buttonTr
            // 
            buttonTr.Location = new Point(80, 100);
            buttonTr.Margin = new Padding(4, 4, 4, 4);
            buttonTr.Name = "buttonTr";
            buttonTr.Size = new Size(118, 36);
            buttonTr.TabIndex = 1;
            buttonTr.Text = "Calculate";
            buttonTr.UseVisualStyleBackColor = true;
            buttonTr.Click += button1_Click;
            // 
            // comboBoxTr
            // 
            comboBoxTr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTr.FormattingEnabled = true;
            comboBoxTr.Items.AddRange(new object[] { "Sin", "Cos", "Tan", "Ctg", "Asin", "Acos", "Atan", "Actg" });
            comboBoxTr.Location = new Point(160, 40);
            comboBoxTr.Margin = new Padding(4, 4, 4, 4);
            comboBoxTr.Name = "comboBoxTr";
            comboBoxTr.Size = new Size(188, 33);
            comboBoxTr.TabIndex = 2;
            // 
            // textBoxTr2
            // 
            textBoxTr2.Location = new Point(160, 150);
            textBoxTr2.Margin = new Padding(4, 4, 4, 4);
            textBoxTr2.Name = "textBoxTr2";
            textBoxTr2.Size = new Size(529, 31);
            textBoxTr2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 4;
            label1.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // TrigCalcForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 249);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTr2);
            Controls.Add(comboBoxTr);
            Controls.Add(buttonTr);
            Controls.Add(textBoxTr);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TrigCalcForm";
            Text = "Trigonomentrical Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTr;
        private Button buttonTr;
        private ComboBox comboBoxTr;
        private TextBox textBoxTr2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}