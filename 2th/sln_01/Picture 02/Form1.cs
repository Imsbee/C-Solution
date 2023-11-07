using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;

        Boolean status = false;
        Pen pen = new Pen(Color.Black, 5);

        private void 빨간색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void 파란색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void 검은색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void 선두께입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("선두께입력: ");
            pen.Width = int.Parse(str);
        }

        private void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh(); 
        }

        private void 지우개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        }


       
    }
}
