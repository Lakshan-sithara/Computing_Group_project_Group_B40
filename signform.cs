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
    public partial class signform_new : Form
    {
        public signform_new()
        {
            //InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            //string username = userNameBox.Text.Trim();
            ///string pass = passwordBox.Text.Trim();

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // Check login for admin
                MySqlCommand adminCommand = new MySqlCommand("SELECT * FROM admin WHERE username = @username AND password = @password", mySqlConnection);
                //adminCommand.Parameters.AddWithValue("@username", username);
                //adminCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader adminReader = adminCommand.ExecuteReader();

                if (adminReader.Read())
                {
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
                //academicCommand.Parameters.AddWithValue("@username", username);
                //academicCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader academicReader = academicCommand.ExecuteReader();

                if (academicReader.Read())
                {
                    MessageBox.Show("Login Successful as Academic");
                    // Open academic dashboard or window
                    AcademicStaffProfile academic = new AcademicStaffProfile();
                    academic.Show();
                    this.Hide();
                    return;
                }

                academicReader.Close(); // Close the academic reader

                // Check login for non-academic (if applicable)
                MySqlCommand nonAcademicCommand = new MySqlCommand("SELECT * FROM non-academic_staff WHERE Username = @username AND Password = @password", mySqlConnection);
                //nonAcademicCommand.Parameters.AddWithValue("@username", username);
                //nonAcademicCommand.Parameters.AddWithValue("@password", pass);
                MySqlDataReader nonAcademicReader = nonAcademicCommand.ExecuteReader();
                // Check login for parent (if applicable)
                if (nonAcademicReader.Read())
                {
                    MessageBox.Show("Login Successful as Non-Academic Staff");
                    // Open non-academic dashboard or window
                    Non_academic_profile nonAcademic = new Non_academic_profile();
                    nonAcademic.Show();
                    this.Hide();
                    return;
                }
                nonAcademicReader.Close();




                // If none of the above matches, show invalid login message
                MessageBox.Show("Invalid Username or Password");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            finally
            {
                mySqlConnection.Close();
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //passwordBox.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
