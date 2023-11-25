namespace TicTacToeApp
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            Player2Timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Location = new Point(155, 537);
            button1.Name = "button1";
            button1.Size = new Size(116, 67);
            button1.TabIndex = 1;
            button1.Text = "New Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NewGame;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(311, 537);
            button2.Name = "button2";
            button2.Size = new Size(107, 67);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Exit;
            // 
            // panel1
            // 
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(62, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 450);
            panel1.TabIndex = 3;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.GradientInactiveCaption;
            button11.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(300, 300);
            button11.Name = "button11";
            button11.Size = new Size(150, 150);
            button11.TabIndex = 19;
            button11.Text = "?";
            button11.UseVisualStyleBackColor = false;
            button11.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.GradientInactiveCaption;
            button10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(150, 300);
            button10.Name = "button10";
            button10.Size = new Size(150, 150);
            button10.TabIndex = 18;
            button10.Text = "?";
            button10.UseVisualStyleBackColor = false;
            button10.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GradientInactiveCaption;
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(0, 300);
            button9.Name = "button9";
            button9.Size = new Size(150, 150);
            button9.TabIndex = 17;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientInactiveCaption;
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(300, 150);
            button8.Name = "button8";
            button8.Size = new Size(150, 150);
            button8.TabIndex = 16;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(150, 150);
            button7.Name = "button7";
            button7.Size = new Size(150, 150);
            button7.TabIndex = 15;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientInactiveCaption;
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(0, 150);
            button6.Name = "button6";
            button6.Size = new Size(150, 150);
            button6.TabIndex = 14;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientInactiveCaption;
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(300, 0);
            button5.Name = "button5";
            button5.Size = new Size(150, 150);
            button5.TabIndex = 13;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(150, 0);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 12;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 3;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(62, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 4;
            label1.Text = "Player X Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(365, 18);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 5;
            label2.Text = "Player Y Wins:";
            // 
            // Player2Timer
            // 
            Player2Timer.Interval = 1000;
            Player2Timer.Tick += Player2move;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(582, 753);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Tic Tac Toe Game";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private System.Windows.Forms.Timer Player2Timer;
    }
}