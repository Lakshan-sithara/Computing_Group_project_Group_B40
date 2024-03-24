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
    public partial class Student_result : Form
    {
        string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
        public Student_result()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn))
            {
                mySqlConnection.Open();
                string query = "SELECT Subject_name,Marks FROM subject WHERE SID=@SID";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@SID", SIDTB.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                examResultDGV.DataSource = dt;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
