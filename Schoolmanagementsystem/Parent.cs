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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            mySqlConnection.Open();
            if(PIDTB.Text != "") { 
                MySqlCommand cmd = new MySqlCommand("SELECT Name,NIC,DOB,Gender,Religion,Occupation,SID FROM parent WHERE ParentID = @ParentID OR SID=@SID", mySqlConnection);
                cmd.Parameters.AddWithValue("@ParentID", PIDTB.Text);
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nameTB.Text = reader.GetString("Name");
                        NICTB.Text = reader.GetString("NIC");
                        DOBTB.Text = reader.GetString("DOB");
                        genderTB.Text = reader.GetString("Gender");
                        religionTB.Text = reader.GetString("Religion");
                        occupationTB.Text = reader.GetString("Occupation");
                        SIDTB.Text = reader.GetString("SID");

                    }
                    else
                    {
                        MessageBox.Show("Parant ID No found");
                    }
                }
            }
            mySqlConnection.Close();
        }
    }
}
