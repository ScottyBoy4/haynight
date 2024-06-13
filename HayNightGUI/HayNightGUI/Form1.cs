using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayNightGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Vars
            int x = 0;
            int y = 0;
            Graphics paper = background.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.DarkGreen);

            //Clear Picturebox
            background.Refresh();

            //Draw a square
            paper.FillRectangle(brush, x, y, x+798, y+448);
            brush = new SolidBrush(Color.SandyBrown);
            paper.FillRectangle(brush, x+(background.Width/2)-75, y, x + 100, y + 375);
            brush = new SolidBrush(Color.Gray);
            paper.FillRectangle(brush, x, (background.Width / 2) - 75, x + 798, y + 150);
        }
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (truck.Left == 663 || truck.Left == 533)
            {
                i++;
                if(i == 300)
                {
                    truck.Left -= 1;
                }
            }
            else
            {
                truck.Left -= 1;
                i = 0;
            }



            if (truck.Left < -100)
            {
                truck.Left = 2000;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            
        }

        private void truck_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            car.Left -= rand.Next(1, 5);
            if (car.Left < -100)
            {
                car.Left = rand.Next(1000,1500);
            }
        }
    }
}
