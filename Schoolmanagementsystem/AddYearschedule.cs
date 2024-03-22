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
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string insertQuery = "INSERT INTO class (Year_start_date,Year_end_date,Term_start_date,Term_end_date) VALUES('"+yearStart+"','"+yearEnd+"','"+termStart+"','"+termEnd+"') ";
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
            conn.Close();
        }
    }
}
