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
    public partial class Addstudentdetails : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        Image i;
        Bitmap b;
        string Gender;
        string grade;
        string Class;
        public Addstudentdetails()
        {
            InitializeComponent();
        }

        private void Addstudentdetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addstudentdetails_Load_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addstudentdetails addstudentdetails = new Addstudentdetails();
            addstudentdetails.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addacademicdetails addacademicdetails = new Addacademicdetails();
            addacademicdetails.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addnonacademicdetails addnonacademicdetails = new Addnonacademicdetails();
            addnonacademicdetails.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addparentdetails addparentdetails = new Addparentdetails();
            addparentdetails.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //add student details
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO student (Name, Admission_number, DOB, Religion, Address, Father_name, Mother_name, gender,Grade,Class,Addmission_date) " +
                                     "VALUES ('" + nameTB.Text + "', '" + AdmiNuTB.Text + "', '" + DOBDTP.Value.ToString("yyyy-MM-dd") + "', '" + religionTB.Text + "', " +
                                     "'" + addressTB.Text + "', '" + fatherTB.Text + "', '" + motherTB.Text + "', '" + Gender + "','" + grade + "','" + Class + ",'"+addmission_date_DTP.Value.ToString("yyyy-MM-dd")+"')";
                MySqlCommand command = new MySqlCommand(insertQuery, conn);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student details added successfully");
                }
                else
                {
                    MessageBox.Show("Student details not added");
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            grade = "Grade 1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            grade = "Grade 2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            grade = "Grade 3";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            grade = "Grade 4";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            grade = "Grade 5";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Class = "Class A";

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Class = "Class B";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Class = "Class C";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Class = "Class D";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //update student details
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string updateQuery = "UPDATE student SET Name = @Name, DOB = @DOB, Religion = @Religion, Address = @Address, " +
                                     "Father_name = @FatherName, Mother_name = @MotherName, Gender = @Gender, " +
                                     "Grade = @Grade, Class = @Class WHERE Admission_number = @AdmissionNumber";

                MySqlCommand command = new MySqlCommand(updateQuery, conn);
                command.Parameters.AddWithValue("@Name", nameTB.Text);
                command.Parameters.AddWithValue("@DOB", DOBDTP.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Religion", religionTB.Text);
                command.Parameters.AddWithValue("@Address", addressTB.Text);
                command.Parameters.AddWithValue("@FatherName", fatherTB.Text);
                command.Parameters.AddWithValue("@MotherName", motherTB.Text);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Grade", grade);
                command.Parameters.AddWithValue("@Class", Class);
                command.Parameters.AddWithValue("@AdmissionNumber", AdmiNuTB.Text);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student details updated successfully");
                }
                else
                {
                    MessageBox.Show("No student with the specified admission number found");
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
            //delete student details
            string connString = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string deleteQuery = "DELETE FROM student WHERE Admission_number = @AdmissionNumber";

                MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@AdmissionNumber", AdmiNuTB.Text);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student data deleted successfully");
                }
                else
                {
                    MessageBox.Show("No student with the specified admission number found");
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



