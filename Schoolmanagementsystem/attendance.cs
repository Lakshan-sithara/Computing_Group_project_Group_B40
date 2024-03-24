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
    public partial class attendance : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string att;
        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            att = "Present";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            att = "Absent";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO attendance (SID, Date, Attendance) VALUES ('" + SIDTB.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + att + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Attendance Recorded");
                }
                else
                {
                    MessageBox.Show("Error");
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

        private void button2_Click(object sender, EventArgs e)
        {
            show_attendance show_Attendance = new show_attendance();
            show_Attendance.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AcademicStaffProfile academicStaffProfile = new AcademicStaffProfile();
            academicStaffProfile.Show();
            this.Hide();
        }
    }
}
