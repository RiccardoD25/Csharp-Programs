namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The below methods are acceptable with the number of days at the hospital

        // and medical charges as arguments and return the equivalent total of charges.

        private double CalcStayCharges(double days)

        {

            return days * 350.0;

        }

        private double CalcMiscCharges(double medical, double surgical, double lab, double rehab)

        {

            return (medical + surgical + lab + rehab);

        }

        private double CalcTotalCharges(double days, double medical, double surgical, double lab, double rehab)

        {

            return CalcStayCharges(days) + CalcMiscCharges(medical, surgical, lab, rehab);

        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the number of days spent at the hospital, amount of medication, surgical, lab and rehab charges.

            double days, medical, surgical, lab, rehab, totalCharges;

            // Get the number of days.

            if (!double.TryParse(daystextBox.Text, out days) || days <= 0.0)

            {

                MessageBox.Show("Length of stay (days) is invalid. Please add a value");

                daystextBox.Focus();

                return;

            }

            // Get the medication charges

            if (!double.TryParse(medicationtextBox.Text, out medical) || medical < 0.0)

            {

                MessageBox.Show("Medication charges are invalid. Please add a value");

                medicationtextBox.Focus();

                return;

            }

            // Get the surgical charges

            if (!double.TryParse(surgicaltextBox.Text, out surgical) || surgical < 0.0)

            {

                MessageBox.Show("Surgical charges are invalid. Please add a value");

                surgicaltextBox.Focus();

                return;

            }

            // Get the lab fees

            if (!double.TryParse(labtextBox.Text, out lab) || lab < 0.0)

            {

                MessageBox.Show("Lab fees are invalid. Please add a value");

                labtextBox.Focus();

                return;

            }

            // Get the physical rehabilitation charges

            if (!double.TryParse(rehabtextBox.Text, out rehab) || rehab < 0.0)

            {

                MessageBox.Show("Phycial rehabilitation charges are invalid. Please add a value");

                rehabtextBox.Focus();

                return;

            }

            // Calculate the total charges.

            totalCharges = CalcTotalCharges(days, medical, surgical, lab, rehab);

            // Display the total charges.

            totalstaylabel.Text = totalCharges.ToString("n2");


        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            // Close the form.

            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            daystextBox.Clear();
            medicationtextBox.Clear();
            surgicaltextBox.Clear();
            labtextBox.Clear();
            rehabtextBox.Clear();
            totalstaylabel.Text = "";
        }
    }
}