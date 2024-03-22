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
    public partial class Addparentdetails : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string gender;
        Image i;
        Bitmap b;
        public Addparentdetails()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                i = Image.FromFile(ofd.FileName);
                b = (Bitmap)i;
                pictureBox1.Image = b;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Add parent details
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO parant (Name,NIC,DOB,Gender,Religion,Mobile_no,Address,Occupation,SID,relationship,PID) VALUES('" + nameTB.Text + "','" + NICTB.Text + "','" + DOBDTB + "','" + gender + "','" + ReTB.Text + "','" + MobileTB + "','" + AddressTB.Text + "','" + OccTB.Text + "','" + CADTB + "','" + relationTB.Text + "','" + PIDTB + "') ";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Parent details added successfully");
                }
                else
                {
                    MessageBox.Show("Parent details not added");
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

        private void button11_Click(object sender, EventArgs e)
        {
            // Update parent details
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // Assuming AID is a unique identifier in your academic table
                string updateQuery = "UPDATE patant SET Name = @Name, NIC = @NIC, DOB = @DOB, Gender = @Gender, Religion = @Religion, " +
                                     "Mobile_no = @MobileNo, Address = @Address,Occupation= @Occupation,SID=@SID,relationship=@relationship WHERE AID = @AID";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                cmd.Parameters.AddWithValue("@NIC", NICTB.Text);
                cmd.Parameters.AddWithValue("@DOB", DOBDTB.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Religion", ReTB.Text);
                cmd.Parameters.AddWithValue("@MobileNo", MobileTB.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTB.Text);
                cmd.Parameters.AddWithValue("@Occupation", OccTB);
                cmd.Parameters.AddWithValue("@SID", CADTB.Text);
                cmd.Parameters.AddWithValue("@relationship", relationTB.Text);
                cmd.Parameters.AddWithValue("@PID", PIDTB.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Parant details updated successfully");
                }
                else
                {
                    MessageBox.Show("No parant record with the specified Academic ID found");
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

        private void button10_Click(object sender, EventArgs e)
        {
            //delete parent record
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string deleteQuery = "DELETE FROM parant WHERE PID = @PID";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@AID", PIDTB.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Parant record deleted successfully");
                }
                else
                {
                    MessageBox.Show("No Parant record with the specified Academic ID found");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
