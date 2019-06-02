using System;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        int x = 30;
        int speed = 10;
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(1500, 600);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Red, 4);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graph.Clear(Color.Transparent);

            graph.DrawLine(pen, x, 60, x, 90);
            graph.DrawLine(pen, x, 90, x + 30, 90);
            graph.DrawEllipse(pen, x + 30, 75, 30, 30);
            graph.DrawLine(pen, x + 60, 90, x + 240, 90);
            graph.DrawEllipse(pen, x + 240, 75, 30, 30);
            graph.DrawLine(pen, x + 270, 90, x + 300, 90);
            graph.DrawLine(pen, x + 300, 90, x + 300, 60);
            graph.DrawLine(pen, x + 300, 30, x, 30);

            Rectangle rect = new Rectangle(x, 30, 300, 30);
            Region region = new Region(rect);
            graph.DrawRectangle(pen, rect);
            graph.FillRegion(Brushes.Blue, region);

            pictureBox1.Image = bmp;

            x += speed;
            if (x < 0 || x + 300 > 1000)
            {
                speed = -speed;
            }
        }
    }
}