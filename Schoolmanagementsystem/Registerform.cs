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
    public partial class Registerform : Form

    {

        public Registerform()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signform signIn = new signform();
            signIn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=school_managment_system;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            if (P1.Text != P1.Text)
            {
                MessageBox.Show("Password do not match!");
                return;
            }if(string.IsNullOrEmpty(IndexNo.Text)|| string.IsNullOrEmpty(rUname.Text)|| string.IsNullOrEmpty(P1.Text) || string.IsNullOrEmpty(P2.Text) || string.IsNullOrEmpty(cmbSelect.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                mySqlConnection.Open();
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelect.Items.Add("Admin");
            cmbSelect.Items.Add("Teacher");
            cmbSelect.Items.Add("Student");
            cmbSelect.Items.Add("Parent");
            cmbSelect.Items.Add("Non-Academic");
            
        }
    }
}
