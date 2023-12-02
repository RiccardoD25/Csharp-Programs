namespace BookPurchasingApp
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgress = new ProgressBar();
            label2 = new Label();
            PercentageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 27);
            label1.Name = "label1";
            label1.Size = new Size(608, 39);
            label1.TabIndex = 0;
            label1.Text = "Book Purchase Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 414);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(12, 568);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(754, 31);
            MyProgress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(12, 536);
            label2.Name = "label2";
            label2.Size = new Size(118, 29);
            label2.TabIndex = 3;
            label2.Text = "Loading...";
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PercentageLbl.ForeColor = Color.SteelBlue;
            PercentageLbl.Location = new Point(124, 536);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(35, 29);
            PercentageLbl.TabIndex = 4;
            PercentageLbl.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 626);
            Controls.Add(PercentageLbl);
            Controls.Add(label2);
            Controls.Add(MyProgress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar MyProgress;
        private Label label2;
        private Label PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}