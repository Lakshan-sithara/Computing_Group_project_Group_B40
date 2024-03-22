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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            signform signform = new signform();
            signform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            signform adminSign = new signform();
            adminSign.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            signform signform = new signform();
            signform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signform signform = new signform();
            signform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signform signform = new signform();
            signform.Show();
            this.Hide();
        }
    }
}
