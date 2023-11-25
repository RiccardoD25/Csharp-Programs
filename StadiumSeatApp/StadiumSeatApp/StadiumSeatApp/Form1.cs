namespace StadiumSeatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateRevenueButton_Click(object sender, EventArgs e)
        {
            // Constants for ticket prices
            const double ClassAPrice = 15.0;
            const double ClassBPrice = 12.0;
            const double ClassCPrice = 9.0;
            // Variables to store the number of tickets sold for each class
            int classATickets, classBTickets, classCTickets;

            // Parse user input for each class
            if (!int.TryParse(ClassATextBox.Text, out classATickets))
            {
                MessageBox.Show("Please enter a valid number of Class A tickets.");
                return;
            }

            if (!int.TryParse(ClassBTextBox.Text, out classBTickets))
            {
                MessageBox.Show("Please enter a valid number of Class B tickets.");
                return;
            }

            if (!int.TryParse(ClassCTextBox.Text, out classCTickets))
            {
                MessageBox.Show("Please enter a valid number of Class C tickets.");
                return;
            }

            // Calculate revenue for each class and total revenue
            double classARevenue = classATickets * ClassAPrice;
            double classBRevenue = classBTickets * ClassBPrice;
            double classCRevenue = classCTickets * ClassCPrice;
            double totalRevenue = classARevenue + classBRevenue + classCRevenue;

            // Display revenue in the corresponding labels
            ClassARevenueLabel.Text = classARevenue.ToString("C");
            ClassBRevenueLabel.Text = classBRevenue.ToString("C");
            ClassCRevenueLabel.Text = classCRevenue.ToString("C");
            TotalRevenueLabel.Text = totalRevenue.ToString("C");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear input and output fields
            ClassATextBox.Clear();
            ClassBTextBox.Clear();
            ClassCTextBox.Clear();
            ClassARevenueLabel.Text = "";
            ClassBRevenueLabel.Text = "";
            ClassCRevenueLabel.Text = "";
            TotalRevenueLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
    }
}