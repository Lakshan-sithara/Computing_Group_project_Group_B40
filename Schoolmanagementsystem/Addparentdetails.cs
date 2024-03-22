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
    public partial class Addparentdetails : Form
    {
        string server = "localhost";
        string database = "sms_database";
        string uid = "root";
        string password = "";
        string gender;
        Image i;
        Bitmap b;
        public Addparentdetails()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                i = Image.FromFile(ofd.FileName);
                b = (Bitmap)i;
                pictureBox1.Image = b;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connString = $"server={server};user={uid};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO parant (Name,NIC,DOB,Gender,Religion,Mobile_no,Address,Occupation,SID,relationship) VALUES('" + nameTB.Text + "','" + NICTB.Text + "','" + DOBDTB + "','" + gender + "','" + ReTB.Text + "','" + MobileTB + "','" + AddressTB.Text + "','"+OccTB.Text+"','"+CADTB+"','"+relationTB.Text +"') ";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Parent details added successfully");
                }
                else
                {
                    MessageBox.Show("Parent details not added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }
    }
}
