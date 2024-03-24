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
    public partial class Year_schedule : Form
    {
        public Year_schedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                mySqlConnection.Open();
                string query = "SELECT Year_start_date, Year_end_date, Term_start_date, Term_end_date FROM class";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                // Create a DataTable with the desired columns
                DataTable dt = new DataTable();
                dt.Columns.Add("Year_start_date", typeof(DateTime));
                dt.Columns.Add("Year_end_date", typeof(DateTime));
                dt.Columns.Add("Term_start_date", typeof(DateTime));
                dt.Columns.Add("Term_end_date", typeof(DateTime));

                // Read data and convert MySQL date/time values to System.DateTime
                while (mySqlDataReader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Year_start_date"] = mySqlDataReader.GetDateTime("Year_start_date");
                    row["Year_end_date"] = mySqlDataReader.GetDateTime("Year_end_date");
                    row["Term_start_date"] = mySqlDataReader.GetDateTime("Term_start_date");
                    row["Term_end_date"] = mySqlDataReader.GetDateTime("Term_end_date");
                    dt.Rows.Add(row);
                }

                // Bind DataTable to DataGridView
                dataGridView1.DataSource = dt;
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
