using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalCharges
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
            days = new Label();
            medical = new Label();
            surgical = new Label();
            lab = new Label();
            rehab = new Label();
            totalCharges = new Label();
            daystextBox = new System.Windows.Forms.TextBox();
            medicationtextBox = new System.Windows.Forms.TextBox();
            surgicaltextBox = new System.Windows.Forms.TextBox();
            labtextBox = new System.Windows.Forms.TextBox();
            rehabtextBox = new System.Windows.Forms.TextBox();
            totalstaylabel = new Label();
            CalculateButton = new System.Windows.Forms.Button();
            clearbutton = new System.Windows.Forms.Button();
            exitbutton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // days
            // 
            days.AutoSize = true;
            days.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            days.Location = new Point(184, 82);
            days.Name = "days";
            days.Size = new Size(157, 28);
            days.TabIndex = 0;
            days.Text = "Days in Hospital:";
            // 
            // medical
            // 
            medical.AutoSize = true;
            medical.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medical.Location = new Point(191, 145);
            medical.Name = "medical";
            medical.Size = new Size(150, 28);
            medical.TabIndex = 1;
            medical.Text = "Medication Fee:";
            // 
            // surgical
            // 
            surgical.AutoSize = true;
            surgical.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surgical.Location = new Point(220, 214);
            surgical.Name = "surgical";
            surgical.Size = new Size(121, 28);
            surgical.TabIndex = 2;
            surgical.Text = "Surgical Fee:";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab.Location = new Point(259, 289);
            lab.Name = "lab";
            lab.Size = new Size(82, 28);
            lab.TabIndex = 3;
            lab.Text = "Lab Fee:";
            // 
            // rehab
            // 
            rehab.AutoSize = true;
            rehab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rehab.Location = new Point(158, 359);
            rehab.Name = "rehab";
            rehab.Size = new Size(183, 28);
            rehab.TabIndex = 4;
            rehab.Text = "Physical Rehab. Fee:";
            // 
            // totalCharges
            // 
            totalCharges.AutoSize = true;
            totalCharges.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalCharges.Location = new Point(196, 427);
            totalCharges.Name = "totalCharges";
            totalCharges.Size = new Size(145, 28);
            totalCharges.TabIndex = 5;
            totalCharges.Text = "Total Charges:";
            // 
            // daystextBox
            // 
            daystextBox.Location = new Point(352, 86);
            daystextBox.Name = "daystextBox";
            daystextBox.Size = new Size(125, 27);
            daystextBox.TabIndex = 6;
            // 
            // medicationtextBox
            // 
            medicationtextBox.Location = new Point(352, 146);
            medicationtextBox.Name = "medicationtextBox";
            medicationtextBox.Size = new Size(125, 27);
            medicationtextBox.TabIndex = 7;
            // 
            // surgicaltextBox
            // 
            surgicaltextBox.Location = new Point(352, 215);
            surgicaltextBox.Name = "surgicaltextBox";
            surgicaltextBox.Size = new Size(125, 27);
            surgicaltextBox.TabIndex = 8;
            // 
            // labtextBox
            // 
            labtextBox.Location = new Point(352, 290);
            labtextBox.Name = "labtextBox";
            labtextBox.Size = new Size(125, 27);
            labtextBox.TabIndex = 9;
            // 
            // rehabtextBox
            // 
            rehabtextBox.Location = new Point(352, 363);
            rehabtextBox.Name = "rehabtextBox";
            rehabtextBox.Size = new Size(125, 27);
            rehabtextBox.TabIndex = 10;
            // 
            // totalstaylabel
            // 
            totalstaylabel.AutoSize = true;
            totalstaylabel.BackColor = SystemColors.Window;
            totalstaylabel.BorderStyle = BorderStyle.Fixed3D;
            totalstaylabel.Location = new Point(352, 435);
            totalstaylabel.Name = "totalstaylabel";
            totalstaylabel.Size = new Size(123, 22);
            totalstaylabel.TabIndex = 11;
            totalstaylabel.Text = "                            ";
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = SystemColors.ButtonHighlight;
            CalculateButton.Location = new Point(209, 519);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(100, 57);
            CalculateButton.TabIndex = 12;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // clearbutton
            // 
            clearbutton.BackColor = SystemColors.ButtonHighlight;
            clearbutton.Location = new Point(381, 519);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(94, 57);
            clearbutton.TabIndex = 13;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = false;
            clearbutton.Click += clearbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = SystemColors.ButtonHighlight;
            exitbutton.Location = new Point(542, 519);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(95, 57);
            exitbutton.TabIndex = 14;
            exitbutton.Text = "Close";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1103, 730);
            Controls.Add(exitbutton);
            Controls.Add(clearbutton);
            Controls.Add(CalculateButton);
            Controls.Add(totalstaylabel);
            Controls.Add(rehabtextBox);
            Controls.Add(labtextBox);
            Controls.Add(surgicaltextBox);
            Controls.Add(medicationtextBox);
            Controls.Add(daystextBox);
            Controls.Add(totalCharges);
            Controls.Add(rehab);
            Controls.Add(lab);
            Controls.Add(surgical);
            Controls.Add(medical);
            Controls.Add(days);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label days;
        private Label medical;
        private Label surgical;
        private Label lab;
        private Label rehab;
        private Label totalCharges;
        private System.Windows.Forms.TextBox daystextBox;
        private System.Windows.Forms.TextBox medicationtextBox;
        private System.Windows.Forms.TextBox surgicaltextBox;
        private System.Windows.Forms.TextBox labtextBox;
        private System.Windows.Forms.TextBox rehabtextBox;
        private Label totalstaylabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}