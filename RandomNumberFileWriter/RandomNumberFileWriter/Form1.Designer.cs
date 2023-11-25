namespace RandomNumberFileWriter
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
            GenerateButton = new Button();
            button1 = new Button();
            label1 = new Label();
            numOfNumbersTextBox = new TextBox();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.Lime;
            GenerateButton.Font = new Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GenerateButton.ForeColor = Color.DimGray;
            GenerateButton.Location = new Point(277, 272);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(173, 101);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate Button";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Font = new Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(587, 272);
            button1.Name = "button1";
            button1.Size = new Size(174, 101);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 105);
            label1.Name = "label1";
            label1.Size = new Size(304, 28);
            label1.TabIndex = 2;
            label1.Text = "Random Number Output (1-100):";
            // 
            // numOfNumbersTextBox
            // 
            numOfNumbersTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOfNumbersTextBox.Location = new Point(587, 102);
            numOfNumbersTextBox.Name = "numOfNumbersTextBox";
            numOfNumbersTextBox.Size = new Size(174, 34);
            numOfNumbersTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1277, 658);
            Controls.Add(numOfNumbersTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(GenerateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateButton;
        private Button button1;
        private Label label1;
        private TextBox numOfNumbersTextBox;
    }
}