namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(numOfNumbersTextBox.Text, out int numOfNumbers))
                {
                    if (numOfNumbers > 0)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                Random random = new Random();

                                for (int i = 0; i < numOfNumbers; i++)
                                {
                                    int randomNumber = random.Next(1, 101);
                                    writer.WriteLine(randomNumber);
                                }
                            }

                            MessageBox.Show("Random numbers have been written to the file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number of random numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}