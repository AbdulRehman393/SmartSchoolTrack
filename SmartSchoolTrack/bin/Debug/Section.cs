using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartSchool_Track
{
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into classtab values(@classid,@classes,@section)", con);
            cnn.Parameters.AddWithValue("@ClassId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Classes", textBox2.Text);
            cnn.Parameters.AddWithValue("Section", textBox3.Text);
            

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from classtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update classtab set classes=@classes,section=@section where classid =@class" + "id", con);
            cnn.Parameters.AddWithValue("@ClassId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Classes", textBox2.Text);
            cnn.Parameters.AddWithValue("Section", textBox3.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete classtab where classid = @classid", con);
            cnn.Parameters.AddWithValue("@ClassId", int.Parse(textBox1.Text));
          


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from classtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Section_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from classtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    