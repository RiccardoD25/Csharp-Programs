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
          
            // This is for the ticket prices
           
            const double ClassAPrice = 15.0;
            const double ClassBPrice = 12.0;
            const double ClassCPrice = 9.0;
            
            
            // This is for the Variables to store the amount of tickets that are being sold for each of the class
           
            int classATickets, classBTickets, classCTickets;

          
            // This is the Parse user input for each class
            
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

           
            // Here we are calculating the revenue of each class as well as the total revenue
            
            double classARevenue = classATickets * ClassAPrice;
            double classBRevenue = classBTickets * ClassBPrice;
            double classCRevenue = classCTickets * ClassCPrice;
            double totalRevenue = classARevenue + classBRevenue + classCRevenue;

            // This is showing the revenue within the corresponding labels
            
            ClassARevenueLabel.Text = classARevenue.ToString("C");
            ClassBRevenueLabel.Text = classBRevenue.ToString("C");
            ClassCRevenueLabel.Text = classCRevenue.ToString("C");
            TotalRevenueLabel.Text = totalRevenue.ToString("C");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // This is the clear input aswell as the output fields
           
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
            // Here is to Close the application
            
            Application.Exit();
        }
    }
}