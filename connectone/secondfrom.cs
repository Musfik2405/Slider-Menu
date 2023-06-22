using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectone
{
    public partial class secondfrom : Form
    {
        public secondfrom()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=ho;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            String username = usernameS.Text;
            String passward = passwardS.Text;
            String email = emailS.Text;

            String query = "Insert into Login values('" + username + "', '" + passward + "', '"+email+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("SignUp complete");

            con.Close();

                 


          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            showpage so = new showpage();
            Hide();
            so.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Hide();
            fm.ShowDialog();
        }

        private void usernameS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
