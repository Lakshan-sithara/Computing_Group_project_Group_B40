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
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            mySqlConnection.Open();
            if(NAID.Text != "")
            {
                MySqlCommand command = new MySqlCommand("SELECT Name,NIC,DOB,Religion,Admission_date,Mobile_no,Address FROM non-academic_staff WHERE NAID = @non_academic_staff_id", mySqlConnection);
                command.Parameters.AddWithValue("@non_academic_staff_id", NAID.Text);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nameTB.Text = reader.GetString("Name");
                    NICTB.Text = reader.GetString("NIC");
                    DOBTB.Text = reader.GetString("DOB");
                    ReTB.Text = reader.GetString("Religion");
                    AddressTB.Text = reader.GetString("Address");
                    ADdateTB.Text = reader.GetString("Admission_date");
                    mobileTB.Text = reader.GetString("Mobile_no");
                    
                }
            }
            else
            {
                MessageBox.Show("Please enter the NAID");
            }
            mySqlConnection.Close();
        }
    }
}
