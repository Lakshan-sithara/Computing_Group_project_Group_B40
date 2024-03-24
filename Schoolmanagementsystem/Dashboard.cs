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
            Registerform registerForm = new Registerform();
            registerForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registerform registerForm = new Registerform();
            registerForm.Show();
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
            Student_profile studentProfile = new Student_profile();
            studentProfile.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registerform registerForm = new Registerform();
            registerForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Parent parent = new Parent();
            parent.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Year_schedule yearSchedule = new Year_schedule();
            yearSchedule.Show();
            this.Hide();
        }
    }
}
