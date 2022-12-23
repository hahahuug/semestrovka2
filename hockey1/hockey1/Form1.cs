using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hockey1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                disk1.Top = disk1.Top - 30;
            }
            if (e.KeyCode == Keys.S)
            {
                disk1.Top = disk1.Top + 30;
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 'D')
            //{
            //    MessageBox.Show("Клавиша D нажата");
            //}

            //if (e.KeyChar == 'd')
            //{
            //    MessageBox.Show("Клавиша D нажата");
            //}
        }

        private void disk2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                disk2.Top = disk1.Top - 30;
            }
            if (e.KeyCode == Keys.L)
            {
                disk2.Top = disk1.Top + 30;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                disk1.Top = disk1.Top - 30;
            }
            if (e.KeyCode == Keys.S)
            {
                disk1.Top = disk1.Top + 30;
            }
            if (e.KeyCode == Keys.O)
            {
                disk2.Top = disk1.Top - 30;
            }
            if (e.KeyCode == Keys.L)
            {
                disk2.Top = disk1.Top + 30;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            disk1.Top = e.Location.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int speedx = 1;
        int speedy = 1;
        int speed = 1;
        int up;
        int down;
        int right;
        int left;
        int player1 = 0;
        int player2 = 0;

        private void collision()
        {

            //disk1
            int disk1up = disk1.Top;
            int disk1right = disk1.Left + disk1.Width;
            int disk1down = disk1.Top + disk1.Height;
            int disk1left = disk1.Left;

            //disk2
            int disk2up = disk2.Top;
            int disk2right = disk2.Left + disk2.Width;
            int disk2down = disk2.Top + disk2.Height;
            int disk2left = disk2.Left;

            //puck
            int puckup = puck.Top;
            int puckright = puck.Left + puck.Width;
            int puckdown = puck.Top + puck.Height;
            int puckleft = puck.Left;



            puck.Top = puck.Top + speedy;
            puck.Left = puck.Left + speedx;

            int up = 0;
            int right = this.Size.Width - puck.Width;
            int down = this.Size.Height - puck.Height - 37;
            int left = 0;


            //collision disk1
            if(puckdown >= disk1up && puckup <= disk1down && puckleft <= disk1right && puckright >= disk1left)
            {
                speed++;
                speedx = speed;
            }
            //collision disk2
            if (puckdown >= disk2up && puckup <= disk2down && puckleft <= disk2right && puckright >= disk2left)
            {
                speed++;
                speedx = speed*-1;
            }


            if (puck.Top <= up)
            {
                speed++;
                speedy = speed;

            }
            if (puck.Top >= down)
            {
                speed++;
                speedy = speed;
            }
            if (puck.Left >= right)
            {
                timer1.Enabled = false;
                player1++;
               
                
            }
            if (puck.Left <= left)
            {
                timer1.Enabled = false;
                player2++;
                
                
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            collision();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
