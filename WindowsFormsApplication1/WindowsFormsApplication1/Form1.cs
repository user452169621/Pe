﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "2")
            {
                label1.Text = "DAETH TO HUMANS!";
            }
            else
            label1.Text = "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text=="4" ){
                label1.Text = "DAETH TO HUMANS!";
            }
            else
            label1.Text = "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "19")
            {
                label1.Text = "DAETH TO HUMANS!";
            }
            else
            label1.Text = "19";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Nyet";
        }
    }
}
