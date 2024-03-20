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
    public partial class signform : Form
    {
        public signform()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string mySqlConn = "server=127.0.0.1;user=root;database=school_managment_system;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);

            string username = userNameBox.Text.Trim();
            string pass = passwordBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM login WHERE username = @username AND password = @password", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@username", username);
                mySqlCommand.Parameters.AddWithValue("@password", pass);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful");
                    Dashboard form2 = new Dashboard();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
