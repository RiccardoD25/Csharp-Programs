namespace BookPurchasingApp
{
    partial class Books
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            panel2 = new Panel();
            FilterCatCb = new ComboBox();
            RefreshBtn = new Button();
            label4 = new Label();
            BookDGV = new DataGridView();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            PriceTb = new TextBox();
            label7 = new Label();
            QtyTb = new TextBox();
            label6 = new Label();
            CatCb = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            AuthorTb = new TextBox();
            BTitleTb = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(FilterCatCb);
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(CatCb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(AuthorTb);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(272, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 821);
            panel2.TabIndex = 3;
            // 
            // FilterCatCb
            // 
            FilterCatCb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilterCatCb.ForeColor = SystemColors.ControlDarkDark;
            FilterCatCb.FormattingEnabled = true;
            FilterCatCb.Items.AddRange(new object[] { "Programming", "Networking", "Mathematics", "Physics", "English", "Spanish", "Biology", "Database", "Machine Learning", "Calculus", "Physics", "English", "Spanish", "Gaming", "Database", "Machine Learning", "Artificial Intelligence ", "Data Science" });
            FilterCatCb.Location = new Point(292, 344);
            FilterCatCb.Name = "FilterCatCb";
            FilterCatCb.Size = new Size(179, 32);
            FilterCatCb.TabIndex = 24;
            FilterCatCb.Text = "Filter By Category";
            FilterCatCb.SelectedIndexChanged += FilterCatCb_SelecteionChangeComitted;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.Moccasin;
            RefreshBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshBtn.ForeColor = Color.Peru;
            RefreshBtn.Location = new Point(499, 334);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(125, 42);
            RefreshBtn.TabIndex = 23;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Peru;
            label4.Location = new Point(319, 312);
            label4.Name = "label4";
            label4.Size = new Size(121, 29);
            label4.TabIndex = 21;
            label4.Text = "Book List";
            // 
            // BookDGV
            // 
            BookDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BookDGV.BackgroundColor = Color.White;
            BookDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Goldenrod;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Moccasin;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Peru;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Tomato;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BookDGV.DefaultCellStyle = dataGridViewCellStyle2;
            BookDGV.GridColor = SystemColors.ControlDark;
            BookDGV.Location = new Point(0, 382);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersVisible = false;
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 29;
            BookDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookDGV.Size = new Size(923, 439);
            BookDGV.TabIndex = 15;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Moccasin;
            ResetBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.Peru;
            ResetBtn.Location = new Point(611, 195);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(120, 45);
            ResetBtn.TabIndex = 19;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Moccasin;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.Peru;
            DeleteBtn.Location = new Point(468, 193);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(119, 45);
            DeleteBtn.TabIndex = 18;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Moccasin;
            EditBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Peru;
            EditBtn.Location = new Point(321, 193);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(119, 45);
            EditBtn.TabIndex = 17;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Moccasin;
            SaveBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Peru;
            SaveBtn.Location = new Point(174, 193);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(119, 47);
            SaveBtn.TabIndex = 14;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(740, 138);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(156, 32);
            PriceTb.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(740, 106);
            label7.Name = "label7";
            label7.Size = new Size(69, 29);
            label7.TabIndex = 15;
            label7.Text = "Price";
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.Location = new Point(559, 138);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(156, 32);
            QtyTb.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(559, 106);
            label6.Name = "label6";
            label6.Size = new Size(100, 29);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // CatCb
            // 
            CatCb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatCb.ForeColor = SystemColors.ControlDarkDark;
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Programming", "Networking", "Mathematics", "Physics", "English", "Spanish", "Biology", "Database", "Machine Learning", "Calculus", "Physics", "English", "Spanish", "Gaming", "Database", "Machine Learning", "Artificial Intelligence ", "Data Science" });
            CatCb.Location = new Point(373, 138);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(159, 32);
            CatCb.TabIndex = 12;
            CatCb.Text = "Select Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(373, 106);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 10;
            label5.Text = "Categories";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(881, 10);
            label8.Name = "label8";
            label8.Size = new Size(31, 29);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(190, 106);
            label3.Name = "label3";
            label3.Size = new Size(82, 29);
            label3.TabIndex = 6;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 106);
            label2.Name = "label2";
            label2.Size = new Size(123, 29);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // AuthorTb
            // 
            AuthorTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorTb.Location = new Point(190, 138);
            AuthorTb.Name = "AuthorTb";
            AuthorTb.Size = new Size(159, 32);
            AuthorTb.TabIndex = 4;
            // 
            // BTitleTb
            // 
            BTitleTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitleTb.Location = new Point(9, 138);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(159, 32);
            BTitleTb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(355, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 36);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 821);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Peru;
            button5.Location = new Point(20, 697);
            button5.Name = "button5";
            button5.Size = new Size(231, 63);
            button5.TabIndex = 13;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Peru;
            button4.Location = new Point(20, 563);
            button4.Name = "button4";
            button4.Size = new Size(231, 63);
            button4.TabIndex = 12;
            button4.Text = "Dash Board";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Peru;
            button3.Location = new Point(20, 429);
            button3.Name = "button3";
            button3.Size = new Size(231, 63);
            button3.TabIndex = 11;
            button3.Text = "Users";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Moccasin;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Peru;
            button2.Location = new Point(20, 291);
            button2.Name = "button2";
            button2.Size = new Size(231, 63);
            button2.TabIndex = 10;
            button2.Text = "Books";
            button2.UseVisualStyleBackColor = false;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1196, 845);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Label label3;
        private Label label2;
        private TextBox AuthorTb;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private ComboBox CatCb;
        private Label label5;
        private TextBox PriceTb;
        private Label label7;
        private TextBox QtyTb;
        private Label label6;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Label label4;
        private DataGridView BookDGV;
        private Button RefreshBtn;
        private ComboBox BookListCatCb;
        private ComboBox FilterCatCb;
    }
}