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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Addstudentdetails addstudent = new Addstudentdetails();
            addstudent.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Addacademicdetails addacademicdetails = new Addacademicdetails();
            addacademicdetails.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Addparentdetails addparent = new Addparentdetails();
            addparent.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Addnonacademicdetails addnonacademic = new Addnonacademicdetails();
            addnonacademic.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddYearschedule addyear = new AddYearschedule();
            addyear.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_student_details showStudentDetails = new show_student_details();
            showStudentDetails.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Addacademicdetails addacademicdetails = new Addacademicdetails();
            addacademicdetails.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show_parant_details showParantDetails = new show_parant_details();
            showParantDetails.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_academic_staff showAcademicStaff = new show_academic_staff();
            showAcademicStaff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_non_academic_details showNonAcademicDetails = new show_non_academic_details();
            showNonAcademicDetails.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
            this.Hide();
        }
    }
}
