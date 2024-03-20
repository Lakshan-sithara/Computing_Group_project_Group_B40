using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolmanagementsystem
{
    public partial class Addnonacademicdetails : Form
    {
        Image i;
        Bitmap b;
        public Addnonacademicdetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }
    }
}
