using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BookPurchasingApp
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        //Calls out the string from local data base
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\BookPurchasingApp\BookPurchasingApp\BookStoreDb.mdf;Integrated Security=True");
        private void populate()
        {
            con.Open();//Opens the BookTable list of books purchased
            string query = "select * from BookTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];

            con.Close();//Closes the window
        }
        private void Filter()
        {
            con.Open();//Opens the BookTable list of books purchased
            string query = "select * from BookTable where BookCategory='" + FilterCatCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();//Closes the window
        }
        private void button9_Click(object sender, EventArgs e)
        {
            populate();
            CatCb.SelectedItem = -1;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || AuthorTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");//Acitvates when you do not fill out entire form
            }
            else
            {
                try
                {
                    con.Open();//Opens the BookTable list of books purchased
                    string query = "insert into BookTable values ('" + BTitleTb.Text + "','" + AuthorTb.Text + "','" + CatCb.SelectedItem.ToString() + "','" + QtyTb.Text + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book saved Succesfully");
                    con.Close();//Closes the window
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();//Closes the maing scren from top right corner window "X"
        }

        private void FilterCatCb_SelecteionChangeComitted(object sender, EventArgs e)
        {
            Filter();
        }
        public void Reset()
        {
            BTitleTb.Text = "";
            AuthorTb.Text = "";
            CatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            AuthorTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
