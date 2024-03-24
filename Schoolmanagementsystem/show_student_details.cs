using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolmanagementsystem
{
    public partial class show_student_details : Form
    {
        string Class;
        string Grade;
        public show_student_details()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 3";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 4";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 5";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Class = "A";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Class = "B";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Class = "C";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Class = "D";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            try
            {
                mySqlConnection.Open();
                string Query = "SELECT * FROM student WHERE Grade = @Grade AND Class = @Class";
                MySqlCommand command = new MySqlCommand(Query, mySqlConnection);
                command.Parameters.AddWithValue("@Grade", Grade);
                command.Parameters.AddWithValue("@Class", Class);

                // Use ExecuteReader to get data from SELECT query
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Student details retrieved successfully");

                    // Load data into a DataTable to bind to DataGridView
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Bind DataTable to DataGridView
                    classDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No students found for the specified Grade and Class");
                }

                reader.Close(); // Close the reader after use
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
