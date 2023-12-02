namespace BookPurchasingApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            LoginButton = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ClearButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 426);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(48, 233);
            label7.Name = "label7";
            label7.Size = new Size(148, 29);
            label7.TabIndex = 10;
            label7.Text = "Best Service";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 172);
            label6.Name = "label6";
            label6.Size = new Size(189, 29);
            label6.TabIndex = 9;
            label6.Text = "Large Collection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 117);
            label5.Name = "label5";
            label5.Size = new Size(159, 29);
            label5.TabIndex = 8;
            label5.Text = "Amasing Staff";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ClearButton);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LoginButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(257, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 426);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(490, 9);
            label8.Name = "label8";
            label8.Size = new Size(28, 31);
            label8.TabIndex = 17;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Moccasin;
            LoginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Peru;
            LoginButton.Location = new Point(187, 303);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 40);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(55, 250);
            label3.Name = "label3";
            label3.Size = new Size(126, 29);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(187, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 32);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 196);
            label2.Name = "label2";
            label2.Size = new Size(141, 29);
            label2.TabIndex = 7;
            label2.Text = "User Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(187, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 32);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(157, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 2;
            label1.Text = "Book Store";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Moccasin;
            ClearButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.Peru;
            ClearButton.Location = new Point(299, 303);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(106, 40);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button LoginButton;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button ClearButton;
    }
}