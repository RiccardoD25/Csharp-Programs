namespace PetsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            string breed = textBox3.Text;
            Dog myDog = new Dog(name, age, breed);
            myDog.showDog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string owner = textBox4.Text;
            Cat myCat = new Cat(name, owner);
            myCat.showCat();
        }
    }
    public class Dog
    {
        private string name;
        private int age;
        private string breed;

        public Dog(string n, int a, string b)
        {
            name = n;
            age = a;
            breed = b;
        }

        public void showDog()
        {
            MessageBox.Show(name + " is " + age + " years old and it is a " + breed);
        }
    }
}