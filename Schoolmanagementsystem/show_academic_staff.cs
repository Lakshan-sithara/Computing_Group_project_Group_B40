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
            string mySqlConn = "server=127.0.0.1;user=root;database=sms_database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM academic_staff", mySqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            academicDGV.DataSource = ds;
        }

        private void show_academic_staff_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
