using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Schoolmanagementsystem
{
    public partial class Registerform : Form

    {

        public Registerform()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            string username = usernameTB.Text.Trim();
            string pass = passwordTB.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // Check login for admin
                MySqlCommand adminCommand = new MySqlCommand("SELECT * FROM admin WHERE username = @username AND password = @password", mySqlConnection);
                adminCommand.Parameters.AddWithValue("@username", username);
                adminCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader adminReader = adminCommand.ExecuteReader();

                if (adminReader.Read())
                {
                    adminReader.Close(); // Close the admin reader
                    MessageBox.Show("Login Successful as Admin");
                    // Open admin dashboard or window
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    return;
                }
                adminReader.Close(); // Close the admin reader

                // Check login for academic
                MySqlCommand academicCommand = new MySqlCommand("SELECT * FROM academic WHERE Username = @username AND Password = @password", mySqlConnection);
                academicCommand.Parameters.AddWithValue("@username", username);
                academicCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader academicReader = academicCommand.ExecuteReader();

                if (academicReader.Read())
                {
                    academicReader.Close(); // Close the academic reader
                    MessageBox.Show("Login Successful as Academic");
                    // Open academic dashboard or window
                    AcademicStaffProfile academic = new AcademicStaffProfile();
                    academic.Show();
                    this.Hide();
                    return;
                }
                academicReader.Close(); // Close the academic reader

                // Check login for non-academic (if applicable)
                MySqlCommand nonAcademicCommand = new MySqlCommand("SELECT * FROM `non-academic_staff` WHERE Username = @username AND Password = @password", mySqlConnection);
                nonAcademicCommand.Parameters.AddWithValue("@username", username);
                nonAcademicCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader nonAcademicReader = nonAcademicCommand.ExecuteReader();

                if (nonAcademicReader.Read())
                {
                    nonAcademicReader.Close(); // Close the non-academic reader
                    MessageBox.Show("Login Successful as Non-Academic Staff");
                    // Open non-academic dashboard or window
                    Non_academic_profile nonAcademic = new Non_academic_profile();
                    nonAcademic.Show();
                    this.Hide();
                    return;
                }
                nonAcademicReader.Close(); // Close the non-academic reader

                // If none of the above matches, show invalid login message
                MessageBox.Show("Invalid Username or Password");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }



        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //passwordTB.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
