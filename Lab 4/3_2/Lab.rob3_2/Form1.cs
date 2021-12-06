using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Lab.rob3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT name, faculty, course, rate FROM Students",
                un
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();

            dataGridView1.DataSource = st;
        }

        private async void kurs_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Students WHERE Course = @Course",
                un
                );
            getAll.Parameters.AddWithValue("Course", course);
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();
            dataGridView1.DataSource = st;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT max(rate)  FROM Students",
                un
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();

            dataGridView1.DataSource = st;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT count(id) FROM Students WHERE faculty = @faculty",
                un
                );
            getAll.Parameters.AddWithValue("Faculty", faculty);
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();
            dataGridView1.DataSource = st;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT name, faculty, course, rate+12  FROM Students",
               un
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();

            dataGridView1.DataSource = st;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            DataTable st = new DataTable();
            dataGridView1.DataSource = st;
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            un.Open();
            SqlCommand ChangeList = new SqlCommand(
                "WITH MyBD AS (" +
                "SELECT TOP(1) * FROM Students ORDER BY rate)" +
                "DELETE FROM MyBD",
                un
                );
            SqlCommand getList = new SqlCommand(
              "SELECT * FROM Students ",
              un
              );
            SqlDataAdapter adaptGet = new SqlDataAdapter(getList);
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(st);
            un.Close();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\админ\Desktop\3_2\Lab.rob3_2\Students.mdf;Integrated Security=True";
            SqlConnection un = new SqlConnection(db);
            SqlCommand getAll = new SqlCommand(
                "SELECT rate FROM Students WHERE rate = ANY " +
                "(SELECT rate FROM Students WHERE rate > 60)",
                un);

            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable st = new DataTable();
            un.Open();
            adapt.Fill(st);
            un.Close();

            dataGridView1.DataSource = st;
        }
    }
}
