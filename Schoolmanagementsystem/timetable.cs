﻿using MySql.Data.MySqlClient;
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
    public partial class timetable : Form
    {
        string Grade;
        string Class;
        public timetable()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 3";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 4";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 5";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Class = "A";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Class = "B";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Class = "C";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Class = "D";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            try
            {
                mySqlConnection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM time_table WHERE Grade = '" + Grade + "' AND Class = '" + Class + "'", mySqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
