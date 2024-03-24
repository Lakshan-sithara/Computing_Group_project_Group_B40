using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolmanagementsystem
{
    public partial class Add_student_s_marks : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string term;
        public Add_student_s_marks()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            term = "1st Term";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            term = "2nd Term";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            term = "3rd Term";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add marks
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO subject (SID,Subject_Name,Term,Marks,Year) VALUES (@SID,@Subject,@Term,@Mark,@Year)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SID", SIDTB.Text);
                cmd.Parameters.AddWithValue("@Subject", subjectTB.Text);
                cmd.Parameters.AddWithValue("@Term", term);
                cmd.Parameters.AddWithValue("@Mark", marksTB.Text);
                cmd.Parameters.AddWithValue("@Year", yearTB.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Marks added successfully");
                }
                else
                {
                    MessageBox.Show("Marks not added");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "UPDATE subject SET Marks = @Mark,Subject_Name = @Subject,Term = @Term,Year = @Year WHERE SID = @SID ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SID", SIDTB.Text);
                cmd.Parameters.AddWithValue("@Subject", subjectTB.Text);
                cmd.Parameters.AddWithValue("@Term", term);
                cmd.Parameters.AddWithValue("@Mark", marksTB.Text);
                cmd.Parameters.AddWithValue("@Year", yearTB.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Marks updated successfully");
                }
                else
                {
                    MessageBox.Show("Marks not updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT SID,Term,Year,Subject_name,Marks FROM subject  WHERE  SID = '" + SIDTB.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                resultDGV.DataSource = dt;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
