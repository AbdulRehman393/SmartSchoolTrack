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


namespace SmartSchool_Track
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-903S5QE;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            SqlCommand cnn = new SqlCommand("select Username, Password from logintab where Username ='" +txtUsername.Text+ "'and Password ='" +txtPassword.Text+ "' ",con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0 )
            {
                Main mn = new Main();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            con.Close();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
