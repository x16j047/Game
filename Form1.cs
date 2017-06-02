﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int speed = 2;
        int movex, movey;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            movey+=speed;
            movex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movey-=speed;
            movex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movex -= speed;
            movey = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movex += speed;
            movey = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += movex;
            pictureBox1.Top += movey;
        }
    }
}
