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
    public partial class Addstudentmarks : Form
    {
        public Addstudentmarks()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                mySqlConnection.Open();
                string insertQuery = "INSERT INTO subject (Subject_Name,Marks) VALUES ('" + subjectTB + "','" + MarksTB + "') WHERE SID=@SID";
                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);
                command.Parameters.AddWithValue("@SID", SIDBox.Text);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM subject", mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            addMarksDGV.DataSource = ds;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcademicStaffProfile academicStaffProfile = new AcademicStaffProfile();
            academicStaffProfile.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
