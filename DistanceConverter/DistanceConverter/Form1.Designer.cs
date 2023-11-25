namespace DistanceConverter
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fromListBox1 = new ListBox();
            toListBox2 = new ListBox();
            ConvertButton = new Button();
            ExitButton = new Button();
            inputTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 78);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a distance to convert:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 167);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 167);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 2;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 398);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 3;
            label4.Text = "Enter a distance to convert:";
            // 
            // fromListBox1
            // 
            fromListBox1.BackColor = Color.DarkSalmon;
            fromListBox1.ForeColor = Color.White;
            fromListBox1.FormattingEnabled = true;
            fromListBox1.ItemHeight = 20;
            fromListBox1.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromListBox1.Location = new Point(404, 200);
            fromListBox1.Name = "fromListBox1";
            fromListBox1.Size = new Size(183, 144);
            fromListBox1.TabIndex = 4;
            // 
            // toListBox2
            // 
            toListBox2.BackColor = Color.DarkSalmon;
            toListBox2.ForeColor = Color.White;
            toListBox2.FormattingEnabled = true;
            toListBox2.ItemHeight = 20;
            toListBox2.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toListBox2.Location = new Point(660, 200);
            toListBox2.Name = "toListBox2";
            toListBox2.Size = new Size(184, 144);
            toListBox2.TabIndex = 5;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(466, 508);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(141, 61);
            ConvertButton.TabIndex = 6;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(680, 508);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(134, 61);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(660, 71);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(154, 27);
            inputTextBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.White;
            resultLabel.Location = new Point(660, 389);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(266, 29);
            resultLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1169, 649);
            Controls.Add(resultLabel);
            Controls.Add(inputTextBox);
            Controls.Add(ExitButton);
            Controls.Add(ConvertButton);
            Controls.Add(toListBox2);
            Controls.Add(fromListBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox fromListBox1;
        private ListBox toListBox2;
        private Button ConvertButton;
        private Button ExitButton;
        private TextBox inputTextBox;
        private Label resultLabel;
    }
}