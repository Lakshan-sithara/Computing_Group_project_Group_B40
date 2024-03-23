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
    public partial class AddYearschedule : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        public AddYearschedule()
        {
            InitializeComponent();
        }

        private void AddYearschedule_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = $"server={server};user={uid};database={database};password={password}";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                string insertQuery = "INSERT INTO class (Year_start_date, Year_end_date, Term_start_date, Term_end_date) " +
                                     "VALUES(@Ystart, @Yend, @Tstart, @Tend)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@Ystart", yearStart.Value);
                    command.Parameters.AddWithValue("@Yend", yearEnd.Value);
                    command.Parameters.AddWithValue("@Tstart", termStart.Value);
                    command.Parameters.AddWithValue("@Tend", termEnd.Value);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
