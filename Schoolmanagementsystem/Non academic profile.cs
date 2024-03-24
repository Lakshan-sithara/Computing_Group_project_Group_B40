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
    public partial class Non_academic_profile : Form
    {
        string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
        public Non_academic_profile()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timetable tt = new timetable();
            tt.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Addstudenttimetable addstudenttimetable = new Addstudenttimetable();
            addstudenttimetable.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn))
            {
                mySqlConnection.Open();
                string query = "SELECT * FROM `non-academic_staff` WHERE NAID=@NAID";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@NAID", NAIDTB.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                nonDGV.DataSource = dt;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Addstudenttimetable addstudenttimetable = new Addstudenttimetable();
            addstudenttimetable.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
