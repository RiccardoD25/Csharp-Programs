using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(inputTextBox.Text, out inputValue))
            {
                string fromUnit = fromListBox1.SelectedItem.ToString();
                string toUnit = toListBox2.SelectedItem.ToString();

                if (fromUnit == toUnit)
                {
                    resultLabel.Text = $"Converted value is the same: {inputValue} {fromUnit}";
                }
                else
                {
                    double result = ConvertDistance(inputValue, fromUnit, toUnit);
                    resultLabel.Text = $"{inputValue} {fromUnit} = {result} {toUnit}";
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private double ConvertDistance(double value, string fromUnit, string toUnit)
        {
            // Define conversion factors
            double yardsToFeet = 3.0;
            double feetToInches = 12.0;

            // Perform the conversion
            switch (fromUnit)
            {
                case "Yards":
                    value *= yardsToFeet * feetToInches;
                    break;
                case "Feet":
                    value *= feetToInches;
                    break;
                    // No conversion needed if converting from Inches
            }

            // Convert to the desired unit
            switch (toUnit)
            {
                case "Yards":
                    value /= (yardsToFeet * feetToInches);
                    break;
                case "Feet":
                    value /= feetToInches;
                    break;
                    // No conversion needed if converting to Inches
            }

            return value;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}