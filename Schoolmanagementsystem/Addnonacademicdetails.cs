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
using MySql.Data.MySqlClient;

namespace Schoolmanagementsystem
{
    public partial class Addnonacademicdetails : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string gender;
        Image i;
        Bitmap b;
        public Addnonacademicdetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Add non-academic details
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO `non-academic_staff` (Name, NIC, DOB, Gender, Religion, NAID, Admission_date, Mobile_no, Address,Username,Password) " +
                                     $"VALUES ('{nameTB.Text}', '{NICTB.Text}', '{DOBDTB.Value}', '{gender}', '{ReTB.Text}', '{AIDTB.Text}', '{ADDTP.Value}', '{MobileTB}', '{AddressTB.Text}','{usernameTB.Text}','{passwordTB}') ";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Non-academic details added successfully");
                }
                else
                {
                    MessageBox.Show("Non-academic details not added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Update non-academic details
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // Assuming AID is a unique identifier in your academic table
                string updateQuery = "UPDATE `non-academic_staff` SET Name = @Name, NIC = @NIC, DOB = @DOB, Gender = @Gender, Religion = @Religion, " +
                                     "Admission_date = @AdmissionDate, Mobile_no = @MobileNo, Address = @Address,Username=@username,Password=@password WHERE NAID = @NAID";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                cmd.Parameters.AddWithValue("@NIC", NICTB.Text);
                cmd.Parameters.AddWithValue("@DOB", DOBDTB.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Religion", ReTB.Text);
                cmd.Parameters.AddWithValue("@AdmissionDate", ADDTP.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MobileNo", MobileTB.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTB.Text);
                cmd.Parameters.AddWithValue("@NAID", AIDTB.Text);
                cmd.Parameters.AddWithValue("@username", usernameTB.Text);
                cmd.Parameters.AddWithValue("@password", passwordTB.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Non-Academic details updated successfully");
                }
                else
                {
                    MessageBox.Show("No Non-academic record with the specified Academic ID found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string deleteQuery = "DELETE FROM `non-academic_staff` WHERE NAID = @NAID";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@NAID", AIDTB.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Non-Academic record deleted successfully");
                }
                else
                {
                    MessageBox.Show("No Non-academic record with the specified Academic ID found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
