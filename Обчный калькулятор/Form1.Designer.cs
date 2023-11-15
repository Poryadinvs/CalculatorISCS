namespace Обчный_калькулятор
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 123);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 54);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 123);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 54);
            label1.Name = "label1";
            label1.Size = new Size(112, 120);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(587, 54);
            label.Name = "label";
            label.Size = new Size(112, 120);
            label.TabIndex = 3;
            label.Text = "=";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(705, 54);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 123);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(357, 224);
            button1.Name = "button1";
            button1.Size = new Size(212, 107);
            button1.TabIndex = 5;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 398);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label;
        private TextBox textBox3;
        private Button button1;
    }
}