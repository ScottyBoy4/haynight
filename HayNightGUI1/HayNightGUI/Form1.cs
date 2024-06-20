using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            pictureBoxHide.Left = 0;


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
        string crops1File = "cropDirt";
        string crops2File = "cropDirt";
        string crops3File = "cropDirt";
        string crops4File = "cropDirt";

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string farmName = textBoxFarmName.Text;

            
            try
            {

                StreamReader streamReader = new StreamReader($"{farmName}.txt");

                crops1File = streamReader.ReadLine();
                crops2File = streamReader.ReadLine();
                crops3File = streamReader.ReadLine();
                crops4File = streamReader.ReadLine();





                var bmp = new Bitmap($"{crops1File}.png");
                crops1.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops2File}.png");
                crops2.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops3File}.png");
                crops3.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops4File}.png");
                crops4.BackgroundImage = bmp;


                pictureBoxHide.Left = 1000;
                buttonLoad.Left = 1000;
                textBoxFarmName.Left = 600;
                label1.Left = 1000;
                buttonNew.Left = 1000;
            }
            catch
            {
                MessageBox.Show("Farm does not exist");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string farmName = textBoxFarmName.Text;
            
            StreamWriter streamWriter = new StreamWriter($"{farmName}.txt");

            crops1File = "cropMelons2";

            streamWriter.WriteLine(crops1File);
            streamWriter.WriteLine(crops2File);
            streamWriter.WriteLine(crops3File);
            streamWriter.WriteLine(crops4File);
            streamWriter.Close();

            MessageBox.Show($"Farm Saved as \"{farmName}\"");
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string farmName = textBoxFarmName.Text;


            try
            {

                StreamReader streamReader = new StreamReader($"default.txt");

                crops1File = streamReader.ReadLine();
                crops2File = streamReader.ReadLine();
                crops3File = streamReader.ReadLine();
                crops4File = streamReader.ReadLine();





                var bmp = new Bitmap($"{crops1File}.png");
                crops1.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops2File}.png");
                crops2.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops3File}.png");
                crops3.BackgroundImage = bmp;

                bmp = new Bitmap($"{crops4File}.png");
                crops4.BackgroundImage = bmp;


                pictureBoxHide.Left = 1000;
                buttonLoad.Left = 1000;
                textBoxFarmName.Left = 600;
                label1.Left = 1000;
                buttonNew.Left = 1000;


                buttonSave_Click(sender, e);


            }
            catch
            {
                MessageBox.Show("Error Creating New Farm");
            }
        }
    }
}
