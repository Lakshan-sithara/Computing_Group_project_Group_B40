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
    public partial class show_academic_staff : Form
    {
        public show_academic_staff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
                MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
                mySqlConnection.Open();
                if (academicDGV != null)
                {
                    string query = "SELECT * FROM academic";
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(mySqlDataReader);
                        academicDGV.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found");
                    }
                }
                else
                {
                    MessageBox.Show("Error: DataGridView object is not initialized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
        }

        private void show_academic_staff_Load(object sender, EventArgs e)
        {
            
        }
    }
}
