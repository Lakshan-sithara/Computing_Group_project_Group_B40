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
    public partial class AcademicStaffProfile : Form
    {
        string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";

        public AcademicStaffProfile()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Addstudentmarks addstudentmarks = new Addstudentmarks();
            addstudentmarks.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            using(MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn))
            {
                mySqlConnection.Open();
                string quary = "SELECT * FROM academic WHERE AID=@AID";
                MySqlCommand command = new MySqlCommand(quary, mySqlConnection);
                command.Parameters.AddWithValue("@AID", AIDTB.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    teacherDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }
        }
    }
}
