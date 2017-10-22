﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen penEllipse = new Pen(Color.Brown);
            penEllipse.DashStyle = DashStyle.Dash;
            g.DrawEllipse(penEllipse, 20, 20, 200, 150);
            Pen penPie = new Pen(Color.Magenta, 2);
            g.DrawPie(penPie, 20, 20, 200, 150, 45, 90);
            Pen penPie1 = new Pen(Color.BlueViolet, 2);
            g.DrawPie(penPie, 20, 20, 200, 150, 150, 45);
            g.Dispose();

        }
    }
}
