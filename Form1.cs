using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            int sizex;
            int sizey;
            sizex = int.Parse(textBox3.Text);
            sizey = int.Parse(textBox4.Text);
            f2.Size = new Size(sizex, sizey);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int top;
            int left;
            top = int.Parse(textBox1.Text);
            left = int.Parse(textBox2.Text);
            f2.Location = new Point(top, left);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
    }
}
