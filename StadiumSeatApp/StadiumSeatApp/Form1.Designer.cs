namespace StadiumSeatApp
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
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            ClassARevenueLabel = new Label();
            ClassBRevenueLabel = new Label();
            ClassCRevenueLabel = new Label();
            TotalRevenueLabel = new Label();
            ClassATicket = new Label();
            ClassBTickets = new Label();
            ClassCTickets = new Label();
            ClassBTextBox = new TextBox();
            ClassCTextBox = new TextBox();
            ClassATextBox = new TextBox();
            CalculateRevenueButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 107);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Tickets Sold";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 107);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Revenue Generated ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 148);
            label3.Name = "label3";
            label3.Size = new Size(223, 40);
            label3.TabIndex = 2;
            label3.Text = "Enter the number of tickets sold \r\nfor each class of seats.";
            // 
            // ClassARevenueLabel
            // 
            ClassARevenueLabel.AutoSize = true;
            ClassARevenueLabel.Location = new Point(762, 148);
            ClassARevenueLabel.Name = "ClassARevenueLabel";
            ClassARevenueLabel.Size = new Size(15, 20);
            ClassARevenueLabel.TabIndex = 3;
            ClassARevenueLabel.Text = "-";
            // 
            // ClassBRevenueLabel
            // 
            ClassBRevenueLabel.AutoSize = true;
            ClassBRevenueLabel.Location = new Point(762, 196);
            ClassBRevenueLabel.Name = "ClassBRevenueLabel";
            ClassBRevenueLabel.Size = new Size(15, 20);
            ClassBRevenueLabel.TabIndex = 4;
            ClassBRevenueLabel.Text = "-";
            // 
            // ClassCRevenueLabel
            // 
            ClassCRevenueLabel.AutoSize = true;
            ClassCRevenueLabel.Location = new Point(762, 245);
            ClassCRevenueLabel.Name = "ClassCRevenueLabel";
            ClassCRevenueLabel.Size = new Size(15, 20);
            ClassCRevenueLabel.TabIndex = 5;
            ClassCRevenueLabel.Text = "-";
            // 
            // TotalRevenueLabel
            // 
            TotalRevenueLabel.AutoSize = true;
            TotalRevenueLabel.Location = new Point(762, 297);
            TotalRevenueLabel.Name = "TotalRevenueLabel";
            TotalRevenueLabel.Size = new Size(15, 20);
            TotalRevenueLabel.TabIndex = 6;
            TotalRevenueLabel.Text = "-";
            // 
            // ClassATicket
            // 
            ClassATicket.AutoSize = true;
            ClassATicket.Location = new Point(352, 216);
            ClassATicket.Name = "ClassATicket";
            ClassATicket.Size = new Size(63, 20);
            ClassATicket.TabIndex = 7;
            ClassATicket.Text = "Class A: ";
            // 
            // ClassBTickets
            // 
            ClassBTickets.AutoSize = true;
            ClassBTickets.Location = new Point(352, 262);
            ClassBTickets.Name = "ClassBTickets";
            ClassBTickets.Size = new Size(62, 20);
            ClassBTickets.TabIndex = 8;
            ClassBTickets.Text = "Class B: ";
            // 
            // ClassCTickets
            // 
            ClassCTickets.AutoSize = true;
            ClassCTickets.Location = new Point(352, 309);
            ClassCTickets.Name = "ClassCTickets";
            ClassCTickets.Size = new Size(62, 20);
            ClassCTickets.TabIndex = 9;
            ClassCTickets.Text = "Class C: ";
            // 
            // ClassBTextBox
            // 
            ClassBTextBox.BackColor = SystemColors.Info;
            ClassBTextBox.Location = new Point(428, 259);
            ClassBTextBox.Name = "ClassBTextBox";
            ClassBTextBox.Size = new Size(125, 27);
            ClassBTextBox.TabIndex = 13;
            // 
            // ClassCTextBox
            // 
            ClassCTextBox.BackColor = SystemColors.Info;
            ClassCTextBox.Location = new Point(428, 309);
            ClassCTextBox.Name = "ClassCTextBox";
            ClassCTextBox.Size = new Size(125, 27);
            ClassCTextBox.TabIndex = 14;
            // 
            // ClassATextBox
            // 
            ClassATextBox.BackColor = SystemColors.Info;
            ClassATextBox.Location = new Point(428, 213);
            ClassATextBox.Name = "ClassATextBox";
            ClassATextBox.Size = new Size(125, 27);
            ClassATextBox.TabIndex = 16;
            // 
            // CalculateRevenueButton
            // 
            CalculateRevenueButton.BackColor = Color.Peru;
            CalculateRevenueButton.Location = new Point(454, 418);
            CalculateRevenueButton.Name = "CalculateRevenueButton";
            CalculateRevenueButton.Size = new Size(121, 74);
            CalculateRevenueButton.TabIndex = 17;
            CalculateRevenueButton.Text = "Calculate Revenue";
            CalculateRevenueButton.UseVisualStyleBackColor = false;
            CalculateRevenueButton.Click += CalculateRevenueButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.NavajoWhite;
            ClearButton.Location = new Point(600, 418);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(116, 74);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Peru;
            ExitButton.Location = new Point(744, 418);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(120, 74);
            ExitButton.TabIndex = 19;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(687, 148);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 20;
            label4.Text = "Class A:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(687, 196);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 21;
            label5.Text = "Class B:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(688, 245);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 22;
            label6.Text = "Class C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 297);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 23;
            label7.Text = "Total: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1328, 640);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateRevenueButton);
            Controls.Add(ClassATextBox);
            Controls.Add(ClassCTextBox);
            Controls.Add(ClassBTextBox);
            Controls.Add(ClassCTickets);
            Controls.Add(ClassBTickets);
            Controls.Add(ClassATicket);
            Controls.Add(TotalRevenueLabel);
            Controls.Add(ClassCRevenueLabel);
            Controls.Add(ClassBRevenueLabel);
            Controls.Add(ClassARevenueLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Stadium Seating ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label ClassARevenueLabel;
        private Label ClassBRevenueLabel;
        private Label ClassCRevenueLabel;
        private Label TotalRevenueLabel;
        private Label ClassATicket;
        private Label ClassBTickets;
        private Label ClassCTickets;
        private TextBox ClassBTextBox;
        private TextBox ClassCTextBox;
        private TextBox ClassATextBox;
        private Button CalculateRevenueButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}