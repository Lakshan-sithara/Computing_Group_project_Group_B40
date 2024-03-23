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
    public partial class Addstudenttimetable : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string Grade;
        string Class;
        public Addstudenttimetable()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Non_academic_profile non_Academic_Profile = new Non_academic_profile();
            non_Academic_Profile.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                //insert date to time_table
                string insert = "INSERT INTO time_table (Time,Subject,Day,Grade,Class) VALUES ('"+ttDTP.Value+"','"+su1TB.Text+"','"+day1.Text+"','"+Grade+"','"+Class+"')";
                MySqlCommand command = new MySqlCommand(insert, conn);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Time table added successfully");
                }
                else
                {
                    MessageBox.Show("Time table not added");
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
    }
}
