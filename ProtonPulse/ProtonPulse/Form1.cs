using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ProtonPulse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-62LOP5H\\SQLEXPRESS;Initial Catalog=ProductDB;Persist Security Info=True;User ID=sa;Password=indu123;Encrypt=False");
            con.Open();
            SqlCommand command = new SqlCommand("insert into ProductInfoTable values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + DateTime.Parse(dateTimePicker1.Text)+ "','" + int.Parse(textBox4.Text) + "','"+textBox5.Text+"','"+textBox6.Text+"','"+int.Parse(textBox7.Text)+"'", con);

            MessageBox.Show("Successfully Inserted");
            con.Close();
            BindData();


        }

        void BindData()
        {
            string connectionString = "Data Source=DESKTOP-62LOP5H\\SQLEXPRESS;Initial Catalog=ProductDB;Persist Security Info=True;User ID=sa;Password=indu123;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from ProductInfoTable"; // SQL query to fetch data from database
            SqlDataAdapter sd = new SqlDataAdapter(query, con); // Pass the query and connection object to SqlDataAdapter
            DataTable dataTable = new DataTable();
            sd.Fill(dataTable); // Use SqlDataAdapter to fill the DataTable with data from the database
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-62LOP5H\\SQLEXPRESS;Initial Catalog=ProductDB;Persist Security Info=True;User ID=sa;Password=indu123;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update ProductInfoTable set ItemName = '" + textBox2.Text + "', Design = '" + textBox3.Text + "', Color = '" + comboBox1.Text + "', Date = '"+DateTime.Parse(dateTimePicker1.Text)+"', StockSize = '"+textBox4.Text+"',ContactNumber = '"+textBox5.Text+"',Gmail = '"+textBox6.Text+"',ItemPrice = '"+textBox7.Text+"' where ProductID = " + int.Parse(textBox1.Text), con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            con.Close();
            BindData();
        }


    }
}
