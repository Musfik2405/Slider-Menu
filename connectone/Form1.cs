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

namespace connectone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-5903S8A\\SQLEXPRESS;Initial Catalog=ho;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            

            if (tbfirstname.Text == "")
            {
                MessageBox.Show("Enter your User Name");
            }
            else if(tbname.Text == "") {
                MessageBox.Show("Enter your passward");

            }
            else
            {
                String query = "select * from Login where username = @username and passward = @pass";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", tbfirstname.Text);

                cmd.Parameters.AddWithValue("@pass", tbname.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfull");

                    dashboardSidebar se = new dashboardSidebar();
                    Hide();
                    se.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or pass  not correct");
                }


            }

            //prepare query

            //string Firstname = tbfirstname.Text;
            //Console.WriteLine(Firstname);
           // string Secondname = tbname.Text;
            //String query = "Insert INTO Names values('" + Firstname + "', '" + Secondname + "')";

            //execute query

            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();

            con.Close();

            //MessageBox.Show("Data has been saved");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            secondfrom seo = new secondfrom();
            Hide();
            seo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        // private void nextpage_Click(object sender, EventArgs e)
        /// <summary>
        /// /{
        /// </summary>

        //   secondfrom sc = new secondfrom();
        //  Hide();
        //sc.ShowDialog();
        //
        //}
    }
}
