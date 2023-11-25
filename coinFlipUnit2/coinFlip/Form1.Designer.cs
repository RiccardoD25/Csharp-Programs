namespace coinFlip
{
    partial class HeadsOrTailsForm
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
            this.CoinHeadsPictureBox = new System.Windows.Forms.PictureBox();
            this.CoinTailsPictureBox = new System.Windows.Forms.PictureBox();
            this.ShowHeadsButton = new System.Windows.Forms.Button();
            this.ShowTailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoinHeadsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinTailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinHeadsPictureBox
            // 
            this.CoinHeadsPictureBox.BackColor = System.Drawing.Color.Gray;
            this.CoinHeadsPictureBox.BackgroundImage = global::coinFlip.Properties.Resources.Heads1;
            this.CoinHeadsPictureBox.Location = new System.Drawing.Point(21, 12);
            this.CoinHeadsPictureBox.Name = "CoinHeadsPictureBox";
            this.CoinHeadsPictureBox.Size = new System.Drawing.Size(517, 500);
            this.CoinHeadsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CoinHeadsPictureBox.TabIndex = 0;
            this.CoinHeadsPictureBox.TabStop = false;
            // 
            // CoinTailsPictureBox
            // 
            this.CoinTailsPictureBox.BackColor = System.Drawing.Color.Gray;
            this.CoinTailsPictureBox.BackgroundImage = global::coinFlip.Properties.Resources.Tails1;
            this.CoinTailsPictureBox.Location = new System.Drawing.Point(695, 12);
            this.CoinTailsPictureBox.Name = "CoinTailsPictureBox";
            this.CoinTailsPictureBox.Size = new System.Drawing.Size(517, 500);
            this.CoinTailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CoinTailsPictureBox.TabIndex = 1;
            this.CoinTailsPictureBox.TabStop = false;
            this.CoinTailsPictureBox.Visible = false;
            // 
            // ShowHeadsButton
            // 
            this.ShowHeadsButton.AccessibleDescription = "";
            this.ShowHeadsButton.AccessibleName = "";
            this.ShowHeadsButton.BackColor = System.Drawing.Color.Silver;
            this.ShowHeadsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowHeadsButton.Location = new System.Drawing.Point(330, 662);
            this.ShowHeadsButton.Name = "ShowHeadsButton";
            this.ShowHeadsButton.Size = new System.Drawing.Size(192, 93);
            this.ShowHeadsButton.TabIndex = 2;
            this.ShowHeadsButton.Text = "Activate Heads\r\n\r\n";
            this.ShowHeadsButton.UseVisualStyleBackColor = false;
            this.ShowHeadsButton.Click += new System.EventHandler(this.ShowHeadsButton_Click);
            // 
            // ShowTailsButton
            // 
            this.ShowTailsButton.BackColor = System.Drawing.Color.Magenta;
            this.ShowTailsButton.Location = new System.Drawing.Point(528, 662);
            this.ShowTailsButton.Name = "ShowTailsButton";
            this.ShowTailsButton.Size = new System.Drawing.Size(192, 93);
            this.ShowTailsButton.TabIndex = 3;
            this.ShowTailsButton.Text = "Activate Tails";
            this.ShowTailsButton.UseVisualStyleBackColor = false;
            this.ShowTailsButton.Click += new System.EventHandler(this.ShowTailsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Aqua;
            this.ExitButton.Location = new System.Drawing.Point(726, 662);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(192, 93);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Activate Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeadsOrTailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowTailsButton);
            this.Controls.Add(this.ShowHeadsButton);
            this.Controls.Add(this.CoinTailsPictureBox);
            this.Controls.Add(this.CoinHeadsPictureBox);
            this.Name = "HeadsOrTailsForm";
            this.Text = "Coin Flip";
            this.Load += new System.EventHandler(this.HeadsOrTailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoinHeadsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinTailsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoinHeadsPictureBox;
        private System.Windows.Forms.PictureBox CoinTailsPictureBox;
        private System.Windows.Forms.Button ShowHeadsButton;
        private System.Windows.Forms.Button ShowTailsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

