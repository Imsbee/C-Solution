using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;
        Boolean status = false;
        Pen pen = new Pen(Color.Blue, 10);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            Graphics g = CreateGraphics();
            
            if (status == true)
            {
                g.DrawLine(pen, x1, y1, x2, y2);
                x1 = x2;
                y1 = y2;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
            x1 = e.X; 
            y1 = e.Y;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
