
namespace Calc
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
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.CalcMethod_Select = new System.Windows.Forms.ComboBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(73, 47);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(100, 23);
            this.FirstTextBox.TabIndex = 0;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(356, 47);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(100, 23);
            this.SecondTextBox.TabIndex = 1;
            // 
            // CalcMethod_Select
            // 
            this.CalcMethod_Select.FormattingEnabled = true;
            this.CalcMethod_Select.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*",
            "^",
            "√",
            "!"});
            this.CalcMethod_Select.Location = new System.Drawing.Point(205, 46);
            this.CalcMethod_Select.Name = "CalcMethod_Select";
            this.CalcMethod_Select.Size = new System.Drawing.Size(121, 23);
            this.CalcMethod_Select.TabIndex = 3;
            this.CalcMethod_Select.SelectedIndexChanged += new System.EventHandler(this.CalcMethod_Select_SelectedIndexChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(565, 46);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResultTextBox.TabIndex = 4;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(234, 101);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 5;
            this.ResultButton.Text = "button1";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalcMethod_Select);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.ComboBox CalcMethod_Select;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResultButton;
    }
}

