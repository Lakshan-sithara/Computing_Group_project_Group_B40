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
    public partial class show_attendance : Form
    {
        public show_attendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
                using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn))
                {
                    mySqlConnection.Open();
                    string query = "SELECT * FROM attendance WHERE Date=@Date";
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(mySqlDataReader);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
            this.Hide();
        }
    }
}
